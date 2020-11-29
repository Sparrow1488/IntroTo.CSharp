using System;
using System.Collections.Generic;
using NewsBlog_review.UserControls;
using System.Drawing;

namespace NewsBlog_review
{
    public abstract class User
    {
        public static List<User> defaultUsersBase = new List<User>();
        public static List<User> creatorUsersBase = new List<User>();
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Access { get; protected set; }
        public string Description { get; set; }
        public static string RefAvatar { get; set; } = @"C:\Users\Dom\Desktop\The-basis-of-CScharp\$НАРАБОТКИ\РАБОЧИЕ\NewsBlogWF\NewsBlog\AutorizationImage.jpg";
        public Image Avatar { get; set; } = Image.FromFile(RefAvatar);
        public static string RefHatImage { get; set; } = @"C:\Users\Dom\Desktop\The-basis-of-CScharp\$НАРАБОТКИ\РАБОЧИЕ\NewsBlogWF\NewsBlog\hatImage1.jpg";
        public Image HatImage { get; set; } = Image.FromFile(RefHatImage);
        public User(string login, string password)
        {
            if (CheckInBaseDefaultUsers(login, password) == null && CheckInBaseCreators(login, password) == null)
            {
                Login = CheckLogin(login);
                Password = CheckPasswors(password);
                defaultUsersBase.Add(this);
            }
        }
        private static string CheckLogin(string log)
        {
            if (string.IsNullOrWhiteSpace(log)) throw new ApplicationException("Пустой логин!");
            return log;
        }
        private static string CheckPasswors(string pas)
        {
            if (string.IsNullOrWhiteSpace(pas) && pas.Length < 4) throw new ApplicationException("Пустой пароль или слишком короткий!");
            return pas;
        }
        private static User CheckInBaseDefaultUsers(string log, string pas)
        {
            foreach (var user in defaultUsersBase)
            {
                if (user.Login == log && user.Password == pas)
                {
                    return user;
                }
            }
            return null;
        }
        private static User CheckInBaseCreators(string log, string pas)
        {
            foreach (var creator in creatorUsersBase)
            {
                if (creator.Login == log && creator.Password == pas)
                {
                    return creator;
                }
            }
            return null;
        }
        public static User Autorization(string login, string password)
        {
            foreach (var user in defaultUsersBase)
            {
                if (user.Login == login && user.Password == password)
                {
                    return user;
                }
            }
            foreach (var creator in creatorUsersBase)
            {
                if (creator.Login == login && creator.Password == password)
                {
                    return creator;
                }
            }
            return null;
        }
        public static User Registration(string login, string password)
        {
            string correctLogin = CheckLogin(login);
            string correctPasswrod = CheckLogin(password);
            if (CheckInBaseDefaultUsers(login, password) != null) throw new ApplicationException("Пользователь уже существует!");
            if (CheckInBaseCreators(login, password) != null) throw new ApplicationException("Редактор уже существует!");
            return new DefaultUser(correctLogin, correctPasswrod);
        }
        //TODO: REGISTRATION
    }
}
