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
            var good = await db.GetGoodAsync("Milk");
            Console.WriteLine("Founded: {0}; Price: {1}", good.Name, good.Price);
        }
    }
}
