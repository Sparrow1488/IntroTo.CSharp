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

        public string titleText;
        public string text;
        public int id;
        public Post(Panel body, TextBox title, TextBox description)
        {
            postBody = body;
            postTitle = title;
            postText = description;
            allPosts.Add(this);
            id = allPosts.Count - 1;
        }
        public static void ShowAllPosts(Panel mainPanel)
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
        public static void ShowPost(Post post, Panel mainPanel)
        {
            mainPanel.Controls.Add(allPosts[post.id].postBody);
            post.postBody.Height = 200;
            post.postBody.BackColor = Color.Red;
        }
    }
}
