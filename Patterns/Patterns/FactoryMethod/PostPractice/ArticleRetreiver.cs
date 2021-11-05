using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ArticleRetreiver : PostRetreiver
    {
        public ArticleRetreiver(Post post) : base(post)
        {
        }

        public override void RetreiveOnPage()
        {
            if (Post is ArticlePost article)
            {
                Console.WriteLine("ОГО! Это целая статья {0} - {1}. Статья: {2}, {3}", 
                    article?.Title, article?.Description, article?.ArticleTitle, article?.Text);
            }
            else base.RetreiveOnPage();
        }
    }
}
