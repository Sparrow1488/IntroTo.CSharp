using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Post
    {
        public int Id { get; set; }
        public string Title{ get; set; }
        public string Description{ get; set; }
        public virtual PostType Type { get; }
    }
}
