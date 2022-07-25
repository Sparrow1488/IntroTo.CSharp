using System;

namespace LearnSharp4.Automapper.Entities
{
    internal class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
