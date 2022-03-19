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
            var results = await OpenConnection(async connection =>
                                               await connection.QueryAsync<Good>($"SELECT * FROM Goods WHERE Name='{name}'"),
                                               connectionString: ConfigHelper.GetShopConnectionString());
            return results.FirstOrDefault() ?? new Good();
        }

        /// <exception cref="InsertSqlException"></exception>
        public async Task CreateGoodAsync(Good good)
        {
            var successInsert = false;
            try
            {
                var queryValue = new { Name = good.Name, Price = good.Price };
                await OpenConnection(async connection =>
                                     await connection.QueryAsync<Ticket>($"INSERT INTO Goods VALUES (@Name, @Price)", queryValue),
                                     connectionString: ConfigHelper.GetShopConnectionString());
                successInsert = true;
            }
            catch
            {
                successInsert = false;
            }
            if(!successInsert) throw new InsertSqlException("Не удалось добавить запись в таблицу");
        }

        public async Task<Ticket> GetTicketAsync(int id)
        {
            Ticket ticket = new Ticket();
            Good good = new Good();
            var result = await OpenConnection(async connection =>
            {
                ticket = (await connection.QueryAsync<Ticket>($"SELECT * FROM Tickets WHERE Id={id}")).FirstOrDefault() ?? ticket;
                good = (await connection.QueryAsync<Good>($"SELECT * FROM Goods WHERE Id={ticket.ProductId}")).FirstOrDefault() ?? good;
                ticket.Good = good;
                return ticket;
            }, connectionString: ConfigHelper.GetShopConnectionString());
            return result ?? new Ticket();
        }

        public async Task CreateUserAsync(User user)
        {
            int? profileId = null;
            var values = new { Login = user.Login, Password = user.Password, ProfileId = profileId };
            await OpenConnection(async connection =>
                                 await connection.QueryAsync<User>("INSERT INTO Users VALUES (@Login, @Password, @ProfileId)", values),
                                 connectionString: ConfigHelper.GetUsersConnectionString());
        }

        public async Task<User> GetUserAsync(string login)
        {
            return await OpenConnection(async connection =>
                                 (await connection.QueryAsync<User>($"SELECT * FROM Users WHERE Login='{login}'")).FirstOrDefault(),
                                 connectionString: ConfigHelper.GetUsersConnectionString());
        }

        private async Task<T> OpenConnection<T>(Func<IDbConnection, Task<T>> action, string connectionString)
        {
            T result = default;
            using (IDbConnection connection = new SqlConnection(connectionString))
                result = await action.Invoke(connection);
            return result;
        }
    }
}
