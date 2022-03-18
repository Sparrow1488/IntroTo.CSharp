using Dapper;
using LearnSharp4.DapperSql.Exceptions;
using LearnSharp4.DapperSql.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace LearnSharp4.DapperSql.Services
{
    internal class DbService
    {
        public async Task<Good> GetGoodAsync(string name)
        {
            var result = new Good() { Id = -1 };
            using (IDbConnection connection = new SqlConnection(ConfigHelper.GetShopConnectionString()))
            {
                var sqlResults = await connection.QueryAsync<Good>($"SELECT * FROM Goods WHERE Name='{name}'");
                result = sqlResults.FirstOrDefault();
            }
            return result;
        }

        /// <exception cref="InsertSqlException"></exception>
        public async Task CreateGoodAsync(Good good)
        {
            var successInsert = false;
            try
            {
                using (IDbConnection connection = new SqlConnection(ConfigHelper.GetShopConnectionString()))
                {
                    var queryValue = new { Name = good.Name, Price = good.Price };
                    await connection.QueryAsync($"INSERT INTO Goods VALUES (@Name, @Price)", queryValue);
                    successInsert = true;
                }
            }
            catch
            {
                successInsert = false;
            }
            if(!successInsert) throw new InsertSqlException("Не удалось добавить запись в таблицу");
        }
    }
}
