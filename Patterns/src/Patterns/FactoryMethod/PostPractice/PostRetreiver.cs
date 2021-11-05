using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class PostRetreiver
    {
        public PostRetreiver(Post post)
        {
            Post = post;
        }
        public virtual Post Post { get; set; }
        public virtual void RetreiveOnPage()
        {
            Console.WriteLine("Вывел на страницу пост {0} - {1}", Post?.Title, Post?.Description);
        }
    }
}
