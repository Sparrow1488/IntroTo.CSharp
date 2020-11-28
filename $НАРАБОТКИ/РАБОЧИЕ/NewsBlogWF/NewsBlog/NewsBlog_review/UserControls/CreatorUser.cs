using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsBlog_review.UserControls
{
    public class CreatorUser : User
    {
        public CreatorUser(string login, string password) : base(login, password)
        {
            Access = "Creator";
        }
    }
}
