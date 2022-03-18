using Dapper;
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

        public async Task<bool> CreateProductAsync(Good product)
        {
            throw new NotImplementedException();
        }
    }
}
