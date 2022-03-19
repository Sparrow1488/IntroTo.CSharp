using System;
using System.Configuration;

namespace LearnSharp4.DapperSql.Services
{
    internal static class ConfigHelper
    {
        public static string GetShopConnectionString() => ConfigurationManager.ConnectionStrings["ShopDb"].ConnectionString;
        internal static string GetUsersConnectionString() => ConfigurationManager.ConnectionStrings["UsersDb"].ConnectionString;
    }
}
