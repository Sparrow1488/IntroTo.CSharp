namespace LearnSharp4.DapperSql.Models
{
    public class Good
    {
        public Good() { }
        public Good(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int Id { get; private set; } = -1;
        public string Name { get; private set; } = string.Empty;
        public double Price { get; private set; }
    }
}