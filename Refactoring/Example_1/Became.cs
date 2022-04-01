/// <summary>
/// Отрефакторил все, что было позволено, однако это дикий пипяу
/// </summary>

private static void ParseCard(string link, double price, out bool added, out bool exists,
                                        out bool failed, out bool edited)
{
    added = false;
    exists = false;
    failed = false;
    edited = false;

    try
    {
        var uid = ExtractUidFromLink(link);
        var originKey = "modusplus_" + uid;
        if (TryGetExistsOfferFromDb(originKey, out var existsOffer))
        {
            CheckAndProcessExists(existsOffer, price, originKey, out edited, out failed, out exists);
        }
        else
        {
            var content = WebContent.GetPageContentByUrlByProxy(link, null, null, null, Encoding.GetEncoding("UTF-8"));
            var nodeDocument = ConvertHtmlToHtmlNode(content);
            var extractedOffer = ParseOfferUsingCardContent(nodeDocument);
            extractedOffer.Key = originKey;
            extractedOffer.Credate = DateTime.Now;
            extractedOffer.Source = 70;
            extractedOffer.Url = link;
            extractedOffer.Price = price;
            extractedOffer.Contactface = "Модус";
            try
            {
                Logger.Log(extractedOffer.Title, ConsoleColor.Green);

                var offerId = extractedOffer.Save();
                Logger.Log("Добавлена запись в OFFER UID=" + offerId, ConsoleColor.Yellow);
                added = true;
            }
            catch (Exception e)
            {
                Logger.Log("Ошибка при добавлении записи в OFFER", ConsoleColor.Red);
                Logger.Log(e.Message, ConsoleColor.Red);
                failed = true;
                return;
            }
        }
    }
    catch (ParseFailedException ex)
    {
        Logger.Log(ex.Message, ConsoleColor.Red);
        failed = true;
    }
}

private static string ExtractUidFromLink(string link)
{
    var uidLine = link.Trim('/');
    var linkParts = uidLine.Split('/');
    if (linkParts.Length <= 1)
        throw new ParseFailedException("Не удалось получить идентификатор источника: " + link);
    string uid = linkParts[linkParts.Length - 1]
              ?.Replace("?id_vehicle=", string.Empty) ?? string.Empty;

    if (string.IsNullOrWhiteSpace(uid))
        throw new ParseFailedException("Идентификатор источника не определен " + link);
    return uid;
}

private static bool TryGetExistsOfferFromDb(string originKey, out Offer existsOffer)
{
    bool offerExists = false;
    existsOffer = GetExistsOfferByKey(originKey);
    if (existsOffer != null && existsOffer.UID > 0)
        offerExists = true;
    return offerExists;
}

private static Offer ParseOfferUsingCardContent(HtmlNode nodeDocument)
{
    var parsedOffer = new Offer();

    parsedOffer.Distance = ExtractDistanceValueFromNodeDocument(nodeDocument);
    parsedOffer.Year = ExtractYearFromNodeDocument(nodeDocument);
    int kpp = ExtractKppFromNodeDocument(nodeDocument);
    parsedOffer.Kpp = kpp;
    parsedOffer.KPPDetail = kpp;
    parsedOffer.Drive = ExtractDriveFromNodeDocument(nodeDocument);
    parsedOffer.Volume = ExtractEngineVolumeFromNodeDocument(nodeDocument);
    parsedOffer.Vol = ParseEngineVolumeToDigital(parsedOffer.Volume);
    parsedOffer.Horsepower = ExtractHorsepowerFromNodeDocument(nodeDocument);
    parsedOffer.Body = GetFieldValue(nodeDocument, "Кузов:") ?? string.Empty;
    parsedOffer.Engine = GetEngine(GetFieldValue(nodeDocument, "Вид топлива:"));
    parsedOffer.Color = GetFieldValue(nodeDocument, "Цвет:") ?? string.Empty;
    string markaAndModel;
    (parsedOffer.Marka, parsedOffer.Model, markaAndModel) = ExtractMarkaAndModelFromNodeDocument(nodeDocument);
    parsedOffer.Title = ParseOfferTitle(parsedOffer, markaAndModel);
    (parsedOffer.Phone, parsedOffer.City) = ExtractPhoneAndCityFromNodeDocument(nodeDocument);
    parsedOffer.Images = ExtractImagesFromNodeDocument(nodeDocument);
    if (!string.IsNullOrWhiteSpace(parsedOffer.Images))
        parsedOffer.Foto = 1;

    return parsedOffer;
}

private static string ExtractImagesFromNodeDocument(HtmlNode nodeDocument)
{
    string imagesInString = string.Empty;
    var imageContainer = nodeDocument.SelectSingleNode("//ul[@id='car_slider']");
    var images = imageContainer?.SelectNodes("./img");
    if (images != null && images.Any())
    {
        var links = images.Select(s => s?.GetAttributeValue("src", ""))
                            .Where(w => !string.IsNullOrEmpty(w)).ToList();
        if (links?.Any() ?? false)
            imagesInString = string.Join(",", links);
    }
    return imagesInString;
}

private static (string phone, string city) ExtractPhoneAndCityFromNodeDocument(HtmlNode nodeDocument)
{
    string phone = "", city = "";
    var td = nodeDocument.SelectNodes("//h4");
    if (td != null && td?.Count == 2)
    {
        phone = td[0].ChildNodes.Where(n => n.Name == "a").FirstOrDefault()?.InnerText;
        city = td[1].InnerHtml.Replace("г.", string.Empty).Trim();
    }
    return (phone, city);
}

private static string ParseOfferTitle(Offer parsedOffer, string markaAndModel)
{
    string title = string.Empty;
    if (parsedOffer.Vol > 0)
        title += " " + parsedOffer.Vol;
    if (!string.IsNullOrEmpty(parsedOffer.KppString))
        title += " " + parsedOffer.KppString;
    if (parsedOffer.Year > 0)
        title += ", " + parsedOffer.Year;
    if (parsedOffer.Distance > 0)
        title += ", " + parsedOffer.Distance + " км.";
    return title;
}

private static (string marka, string model, string markaAndModel) ExtractMarkaAndModelFromNodeDocument(HtmlNode nodeDocument)
{
    string marka = "", model = "", markaAndModel = "";
    markaAndModel = nodeDocument.SelectSingleNode("//h2[@class='title']")?.InnerText.Replace("\t", string.Empty).Replace("\n", string.Empty);
    if (!string.IsNullOrEmpty(markaAndModel))
    {
        marka = SourceMarkaList.FirstOrDefault(f => markaAndModel.IndexOf(f) >= 0) ?? string.Empty;
        if (!string.IsNullOrEmpty(marka))
        {
            model = markaAndModel.Replace(marka, "").Trim();
            model = model.Remove(model.Length - 6);
        }
    }
    return (marka, model, markaAndModel);
}

private static double ExtractDistanceValueFromNodeDocument(HtmlNode nodeDocument)
{
    double parsedDistance = 0;
    var distanceStringValue = GetFieldValue(nodeDocument, "Пробег:");
    if (!string.IsNullOrEmpty(distanceStringValue))
    {
        distanceStringValue = distanceStringValue.Replace("км", "").Replace(".", "").Trim();
        double.TryParse(distanceStringValue, out parsedDistance);
    }
    return parsedDistance;
}

private static int ExtractYearFromNodeDocument(HtmlNode nodeDocument)
{
    int year = 0;
    var yearStringValue = GetFieldValue(nodeDocument, "Год выпуска:");
    if (!string.IsNullOrWhiteSpace(yearStringValue))
        int.TryParse(yearStringValue, out year);
    return year;
}

private static int ExtractKppFromNodeDocument(HtmlNode nodeDocument) =>
    GetKpp(GetFieldValue(nodeDocument, "Коробка передач:"));

private static int ExtractDriveFromNodeDocument(HtmlNode nodeDocument) =>
    GetDrive(GetFieldValue(nodeDocument, "Привод:"));

private static double ParseEngineVolumeToDigital(string engineVolume)
{
    double digitalEngineVolume = 0;
    engineVolume = engineVolume.Replace(".", ",");
    double.TryParse(engineVolume, out var volume);
    if (volume > 0)
        digitalEngineVolume = volume;
    return digitalEngineVolume;
}

private static string ExtractEngineVolumeFromNodeDocument(HtmlNode nodeDocument)
{
    var engineVolume = GetFieldValue(nodeDocument, "Объем двигателя:");
    return string.IsNullOrWhiteSpace(engineVolume) ? string.Empty : engineVolume;
}

private static int ExtractHorsepowerFromNodeDocument(HtmlNode nodeDocument)
{
    int horsePower = 0;
    var horsesVal = GetFieldValue(nodeDocument, "Мощность:");
    if (!string.IsNullOrEmpty(horsesVal))
    {
        horsesVal = Regex.Replace(horsesVal, "Л.С. / \\d+ кВт", string.Empty);
        int.TryParse(horsesVal, out horsePower);
    }
    return horsePower > 0 ? horsePower : -1;
}

private static HtmlNode ConvertHtmlToHtmlNode(string receivedHtml)
{
    if (string.IsNullOrWhiteSpace(receivedHtml))
        throw new ParseFailedException("Пустой контент карточки объявления");
    var document = new HtmlDocument();
    document.LoadHtml(receivedHtml);
    if (document.DocumentNode == null)
        throw new ParseFailedException("Не удалось спарсить документ");
    return document.DocumentNode;
}