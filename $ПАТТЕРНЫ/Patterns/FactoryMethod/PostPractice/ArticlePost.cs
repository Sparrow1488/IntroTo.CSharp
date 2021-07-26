using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ArticlePost : Post
    {
        public override PostType Type => PostType.Article;
        public string ArticleTitle { get; set; }
        public string Text { get; set; }
    }
}
