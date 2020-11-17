using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {
        //public - публичный открытый - открыт всем и всегда
        //internal - открытый в пределах проекта - доступен только в одном проекте
        //protected - защищенный - доступный только унаследованному классу от базового, остальным - нет
        //private - закрытый - принадлежит ТОЛЬКО этому классу

        public string firstName = "";
        public string LastName = "";

        protected decimal money;


    }
}
