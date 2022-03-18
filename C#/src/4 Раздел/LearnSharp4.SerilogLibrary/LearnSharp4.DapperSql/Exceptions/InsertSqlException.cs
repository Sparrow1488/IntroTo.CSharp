using System;

namespace LearnSharp4.DapperSql.Exceptions
{
    internal class InsertSqlException : Exception
    {
        public InsertSqlException(string message) : base(message) { }
    }
}
