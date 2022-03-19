using LearnSharp4.DapperSql.Models;
using LearnSharp4.DapperSql.Services;
using System;
using System.Threading.Tasks;

namespace LearnSharp4.DapperSql
{
    internal class Program
    {
        private static async Task Main()
        {
            var db = new DbService();
            var rnd = new Random();
            var user = new User($"User_{rnd.Next(9999, 999999)}", "1234");
            var profile = new Profile("Sample desc", "no-image");
            user.Profile = profile;
            await db.CreateUserAsync(user);
            var asd = await db.GetUserAsync("pizda");
        }
    }
}
