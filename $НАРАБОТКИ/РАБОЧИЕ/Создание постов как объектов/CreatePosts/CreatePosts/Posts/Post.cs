using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace CreatePosts.Posts
{
    public class Post
    {
        public static List<Post> allPosts = new List<Post>();
        public Panel postBody;
        public TextBox postTitle;
        public TextBox postText;
        public Post(Panel body, TextBox title, TextBox description)
        {
            postBody = body;
            postTitle = title;
            postText = description;
            allPosts.Add(this);
        }
        public static void ShowPosts(Panel mainPanel)
        {
            foreach (var item in allPosts)
            {
                mainPanel.Controls.Add(item.postBody);
                item.postBody.Height = 200;
                item.postBody.BackColor = Color.Red;
                item.postBody.Container.Add(item.postTitle);
                item.postBody.Container.Add(item.postText);
            }
        }
    }
}
