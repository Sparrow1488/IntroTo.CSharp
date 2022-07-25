using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ArticlePostRetreiverCreator : PostRetreiverCreator
    {
        public override PostRetreiver Create(Post post)
        {
            return new ArticleRetreiver(post);
        }
    }
}
