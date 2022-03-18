using System;

namespace LearnSharp4.DapperSql.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateAtCreated { get; set; }
        public Good Product { get; set; }
    }
}
