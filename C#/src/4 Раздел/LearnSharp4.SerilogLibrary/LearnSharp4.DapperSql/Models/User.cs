namespace LearnSharp4.DapperSql.Models
{
    internal class User
    {
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public User() { }

        public int Id { get; set; } = -1;
        public string Login { get; set; }
        public string Password { get; set; }
        public Profile Profile { get; set; }

        public int ProfileId;
    }
}
