using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            StartPostPractice();
        }
        static void StartPostPractice()
        {
            var article = new ArticlePost() { Id = 1, ArticleTitle = "Статья", Text = "Текст" };
            var imagePost = new PicturePost() { Id = 2, Title = "Картинка", Description = "Тэкxt" };

            PostRetreiverCreator articleRetreiverCreator = new ArticlePostRetreiverCreator();
            PostRetreiver articleRetreiver = articleRetreiverCreator.Create(article);
            articleRetreiver.RetreiveOnPage();

            PostRetreiverCreator imageRetreiverCreator = new PicturePostRetreiverCreator();
            PostRetreiver imageRetreiver = imageRetreiverCreator.Create(imagePost);
            imageRetreiver.RetreiveOnPage();
        }
    }
}
