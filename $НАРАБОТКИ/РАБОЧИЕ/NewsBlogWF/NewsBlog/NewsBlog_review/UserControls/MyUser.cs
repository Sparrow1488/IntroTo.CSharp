using System;
using System.Windows.Forms;

namespace NewsBlog_review.UserControls
{
    public class MyUser<T>
        where T: Label
    {
        public static User ActiveUser { get; set; }
        public static void PrintMyInformation(T log, T pas, T acc, TextBox desc, Panel avatar, Panel hat)
        {
            log.Text = ActiveUser.Login;
            pas.Text = ActiveUser.Password;
            acc.Text = ActiveUser.Access;
            desc.Text = ActiveUser.Description;
            avatar.BackgroundImage = ActiveUser.Avatar;
            hat.BackgroundImage = ActiveUser.HatImage;
        }
    }
}
