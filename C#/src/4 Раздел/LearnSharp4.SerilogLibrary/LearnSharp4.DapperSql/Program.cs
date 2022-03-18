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
            await db.CreateGoodAsync(new Good
            {
                Name = "Snickers",
                Price = 68.40
            });
            var good = await db.GetGoodAsync("Snickers");
            Console.WriteLine("Founded: {0}; Price: {1}", good.Name, good.Price);
        }
    }
}
