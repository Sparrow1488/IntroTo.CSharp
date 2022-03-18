﻿using System;

namespace LearnSharp4.DapperSql.Models
{
    public class Ticket
    {
        public int Id { get; private set; }
        public double TotalPrice { get; private set; }
        public DateTime DateAtCreated { get; private set; }
        public int ProductId { get; private set; }
        public Good Product { get; private set; }
    }
}
