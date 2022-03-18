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
            await db.CreateGoodAsync(new Good("Snickers", 100.20));
            var good = await db.GetGoodAsync("Snickers");
            var ticket = await db.GetTicketAsync(1);
        }
    }
}
