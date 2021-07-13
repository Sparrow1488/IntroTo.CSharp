using System;
using System.Collections.Generic;
using System.Text;

namespace Entity2
{
    public class Admin : Account
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
    }
}
