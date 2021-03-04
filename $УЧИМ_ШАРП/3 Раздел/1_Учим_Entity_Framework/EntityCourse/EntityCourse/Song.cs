using System;
using System.Collections.Generic;
using System.Text;

namespace EntityCourse
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupId { get; set; }
        public virtual Group ByGroup { get; set; }
    }
}
