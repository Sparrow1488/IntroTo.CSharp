using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class PicturePostRetreiver : PostRetreiver
    {
        public PicturePostRetreiver(Post post) : base(post)
        {
        }

        public override void RetreiveOnPage()
        {
            if (Post is PicturePost picturePost)
            {
                Console.WriteLine("Вывел на страницу пост с картинками {0} - {1}. Картинка {2}"
                    , picturePost?.Title, picturePost?.Description, picturePost?.Image);
            }
            else base.RetreiveOnPage();
        }
    }
}
