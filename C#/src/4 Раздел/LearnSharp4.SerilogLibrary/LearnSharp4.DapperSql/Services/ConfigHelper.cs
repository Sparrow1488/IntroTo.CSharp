using System.Configuration;

namespace LearnSharp4.DapperSql.Services
{
    internal static class ConfigHelper
    {
        public static string GetShopConnectionString() => ConfigurationManager.ConnectionStrings["ShopDb"].ConnectionString;
    }
}
