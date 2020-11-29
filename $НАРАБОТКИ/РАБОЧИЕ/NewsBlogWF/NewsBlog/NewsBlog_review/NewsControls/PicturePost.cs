using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NewsBlog_review.NewsControls
{
    public abstract class PicturePost
    {
        public static List<PicturePost> picturePostsBase = new List<PicturePost>();
        public static string Description { get; private set; }
        public static Color MainImage { get; private set; } = Color.Black;
        public static int ID { get; set; }
        public static int index = 0;
        public PicturePost(Color image, string desc)
        {
            Description = desc;
            MainImage = image;
            ID = picturePostsBase.Count - 1;
            picturePostsBase.Add(this);
        }
        public static void PrintPost(PictureBox picture, TextBox text)
        {

        }
    }
}
