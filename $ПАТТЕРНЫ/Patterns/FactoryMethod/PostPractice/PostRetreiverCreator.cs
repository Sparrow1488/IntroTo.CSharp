using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace FactoryMethod
{
    public abstract class PostRetreiverCreator
    {
        public static PostRetreiverCreator GetCreator()
        {
            // рефлексия сломает все !!!!!!!!!!!!!!
            throw new NotImplementedException();
        }
        public abstract PostRetreiver Create(Post post);
    }
}
