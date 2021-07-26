using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace FactoryMethod
{
    public class PicturePost : Post
    {
        public override PostType Type => PostType.Image;
        public Bitmap Image { get; set; }
    }
}
