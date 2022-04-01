private static void ParseCard(string link, double price, out bool added, out bool exists,
                                        out bool failed, out bool edited)
{
    added = false;
    exists = false;
    failed = false;
    edited = false;

    var uidLine = link.Trim('/');
    var linkParts = uidLine.Split('/');
    if (linkParts.Length <= 1)
    {
        Logger.Log("Не удалось получить идентификатор источника: " + link, ConsoleColor.Red);
        failed = true;
        return;
    }

    var uid = linkParts[linkParts.Length - 1]
              .Replace("?id_vehicle=", String.Empty);

    if (string.IsNullOrEmpty(uid))
    {
        Logger.Log("Идентификатор источника не определен " + link, ConsoleColor.Red);
        failed = true;
        return;
    }

    var originKey = "modusplus_" + uid;

    var dbOffer = GetExistsOfferByKey(originKey);
    if (dbOffer != null && dbOffer.UID > 0)
    {
        CheckAndProcessExists(dbOffer, price, originKey, out edited, out failed, out exists);
        return;
    }

    var content = WebContent.GetPageContentByUrlByProxy(link, null, null, null, Encoding.GetEncoding("UTF-8"));
    if (string.IsNullOrEmpty(content))
    {
        Logger.Log("Пустой контент карточки объявления");
        failed = true;
        return;
    }
    var hap = new HtmlDocument();
    hap.LoadHtml(content);
    var doc = hap.DocumentNode;

    var offer = new Offer
    {
        Key = originKey,
        Credate = DateTime.Now,
        Source = 70,
        Url = link,
        Price = price,
        Contactface = "Модус"
    };

    var distanceVal = GetFieldValue(doc, "Пробег:");
    if (!string.IsNullOrEmpty(distanceVal))
    {
        distanceVal = distanceVal.Replace("км", "").Replace(".", "").Trim();
        double.TryParse(distanceVal, out var dist);
        if (dist > 0) offer.Distance = dist;
    }

    var yearVal = GetFieldValue(doc, "Год выпуска:");

    int.TryParse(yearVal, out var year);
    if (year > 0) offer.Year = year;

    var kpp = GetKpp(GetFieldValue(doc, "Коробка передач:"));
    if (kpp > 0)
    {
        offer.Kpp = kpp;
        offer.KPPDetail = kpp;
    }

    var drive = GetDrive(GetFieldValue(doc, "Привод:"));
    if (drive > 0)
    {
        offer.Drive = drive;
    }

    var engineVolume = GetFieldValue(doc, "Объем двигателя:");
    if (!string.IsNullOrEmpty(engineVolume))
    {
        offer.Volume = engineVolume;
        engineVolume = engineVolume.Replace(".", ",");
        double.TryParse(engineVolume, out var volume);
        if (volume > 0)
        {
            offer.Vol = volume;
        }
    }

    var horsesVal = GetFieldValue(doc, "Мощность:");
    if (!string.IsNullOrEmpty(horsesVal))
    {
        horsesVal = Regex.Replace(horsesVal, "Л.С. / \\d+ кВт", String.Empty);
        int.TryParse(horsesVal, out var horses);
        if (horses > 0)
        {
            offer.Horsepower = horses;
        }
    }
    var bodyVal = GetFieldValue(doc, "Кузов:");
    if (!string.IsNullOrEmpty(bodyVal))
    {
        offer.Body = bodyVal;
    }

    int engine = GetEngine(GetFieldValue(doc, "Вид топлива:"));
    if (engine > 0)
    {
        offer.Engine = engine;
    }

    var color = GetFieldValue(doc, "Цвет:");
    if (!string.IsNullOrWhiteSpace(color))
    {
        offer.Color = color;
    }

    var markaModelVal = doc.SelectSingleNode("//h2[@class='title']")?.InnerText.Replace("\t", String.Empty).Replace("\n", String.Empty);
    if (!string.IsNullOrEmpty(markaModelVal))
    {
        var marka = SourceMarkaList.FirstOrDefault(f => markaModelVal.IndexOf(f) >= 0);
        if (!string.IsNullOrEmpty(marka))
        {
            offer.Marka = marka;
            var model = markaModelVal.Replace(marka, "").Trim();
            offer.Model = model.Remove(model.Length - 6);
        }
    }
    var title = markaModelVal;

    if (offer.Vol > 0)
        title += " " + offer.Vol;
    if (!string.IsNullOrEmpty(offer.KppString))
        title += " " + offer.KppString;
    if (offer.Year > 0)
        title += ", " + offer.Year;
    if (offer.Distance > 0)
        title += ", " + offer.Distance + " км.";
    offer.Title = title;

    var td = doc.SelectNodes("//h4");
    if (td.Count == 2)
    {
        offer.Phone = td[0].ChildNodes.Where(n => n.Name == "a").FirstOrDefault()?.InnerText;
        offer.City = td[1].InnerHtml.Replace("г.", String.Empty).Trim();
    }

    var imageContainer = doc.SelectSingleNode("//ul[@id='car_slider']");
    var images = imageContainer?.SelectNodes("./img");
    if (images != null && images.Any())
    {
        var links = images.Select(s => s?.GetAttributeValue("src", ""))
                          .Where(w => !string.IsNullOrEmpty(w)).ToList();
        if (links.Any())
        {
            offer.Images = string.Join(",", links);
            offer.Foto = 1;
        }
    }

    try
    {
        Logger.Log(offer.Title, ConsoleColor.Green);

        var offerId = offer.Save();
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