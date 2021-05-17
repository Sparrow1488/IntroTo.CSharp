using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Base
{
    public class Context
    {
        private IStrategy ContextStrategy;
        public string Text { get; private set; }
        public void NewStrategy(IStrategy strategy)
        {
            ContextStrategy = strategy;
        }
        public void ExecuteAlgorithm()
        {
            ContextStrategy.Algorithm();
        }
    }
}
