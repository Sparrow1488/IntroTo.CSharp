using System;
using NewsBlog_review.UserControls;

namespace NewsBlog_review.UserControls
{
    public class DefaultUser : User
    {
        public DefaultUser(string login, string password) : base(login, password)
        {
            Access = "Default";
        }
    }
}
