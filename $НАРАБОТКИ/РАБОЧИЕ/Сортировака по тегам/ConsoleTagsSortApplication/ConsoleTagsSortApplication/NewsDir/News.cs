using System;
using System.Collections.Generic;
using ConsoleTagsSortApplication.Tags;

namespace ConsoleTagsSortApplication.NewsDir
{
    public class News
    {
        public static List<News> newsAll = new List<News>();
        public List<Tag> tagsInNews = new List<Tag>();
        public string Title;
        public string Descriprion;

        public int ID;
        public News(string title, string description)
        {
            Title = title;
            Descriprion = description;
            newsAll.Add(this);
            ID = newsAll.Count - 1;

        }

        public static void CreateBase()
        {
            new News("В США проголосовали первые выборщики", "Голосование выборщиков делает результаты выборов официальными, но окончательными они станут 6 января, когда совместная сессия конгресса должна утвердить итоги.\n" +
                     "По предварительным данным СМИ, Байден набирает 306 выборщиков против 232 у действующего президента Дональда Трампа.Для победы нужны 270 членов коллегии.\n" +
                     "Трамп поражение не признает и оспаривает результаты в ряде штатов в судах, однако ни один суд пока его не поддержал.")
            {
                tagsInNews = new List<Tag> { Tag.GetTag("игры"), Tag.GetTag("политика"), Tag.GetTag("веселье"), }
            };
            new News("Цены на сахар и масло ограничат до апреля", "На прошлой неделе Владимир Путин обратил внимание на удорожание базовых продуктов, подчеркнув, 'что пандемия здесь ни при чем'. Глава государства отметил рост цен на сахар, подсолнечное масло, муку, макаронные изделия, назвав это попыткой подогнать внутренние цены под мировые." +
                     "Во время совещания с министрами президент потребовал за неделю решить вопрос с ценами.Как подчеркнул Путин, его не устраивают 'надежды' правительства на то, что ситуация на следующей неделе стабилизируется." +
                     "Глава кабмина Михаил Мишустин также раскритиковал министров и вице - премьеров, для решения проблемы в правительстве сформировали межведомственную группу.")
            {
                tagsInNews = new List<Tag> { Tag.GetTag("политика"), Tag.GetTag("спорт") }
            };
            new News("Забили гол в негра", "Неприятный инцидент произошел в одном из российских дворов.\nОчевидцы сообщают, что и самы были бы не против пнуть уголька под его экватору, однако интервью успели прервать")
            {
                tagsInNews = new List<Tag> { Tag.GetTag("веселье"), Tag.GetTag("наука") }
            };
            new News("Прибили юного негретенка", "Это очень прискорбно")
            {
                tagsInNews = new List<Tag> { Tag.GetTag("веселье"), Tag.GetTag("политика") }
            };
        }
        public static void ShowTitleAllNews()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Заголовки:");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var news in newsAll)
            {
                Console.WriteLine($"ID: {news.ID} Title: {news.Title}");
            }
        }
        public static void ShowAllFindNews(string tag)
        {
            foreach (var news in newsAll)
            {
                foreach (var findTag in news.tagsInNews)
                {
                    if (findTag.tagName == tag)
                        news.ReadActiveNews();
                }
            }
        }
        public static List<News> ShowAllNews(List<Tag> tags) // Я ЭТО ПИСАЛ 3 ЧАСААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААА
        {
            var active = new ActiveControls();
            var newsList = new List<News>();
            foreach (var instanceAllNews in newsAll)
            {
                active.ActiveNews = instanceAllNews;
                foreach (var instanceTags in active.ActiveNews.tagsInNews)
                {
                    News MightNews = null;
                    foreach (var findTags in tags)
                    {
                        MightNews = null;
                        if (active.ActiveNews.tagsInNews.Contains(findTags))
                            MightNews = active.ActiveNews;
                        else if (MightNews == null)
                            break;
                    }
                    if (MightNews != null) newsList.Add(MightNews);
                    break;
                }
            }
            return newsList;
        }

        public static void ShowAllNews()
        {
            foreach (var news in newsAll)
            {
                news.ReadActiveNews();
            }
        }
        public static News GetNewsForID(int id)
        {
            if (id < newsAll.Count)
                return newsAll[id];
            else return null;
        }
        public void AddTag(ref Tag tag)
        {
            tagsInNews.Add(tag);
        }
        public void ShowTags()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Новость: '{Title}' с тегами: ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var tag in tagsInNews)
                Console.Write(tag.tagName + " ");
            Console.WriteLine();
        }
        public void ReadActiveNews()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Title);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Descriprion);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("ID:" + ID);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
        

        
    }
}
