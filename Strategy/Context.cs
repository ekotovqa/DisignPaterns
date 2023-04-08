using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoSomething(string inputString) 
        { 
            if (_strategy is null) 
            {
                Console.WriteLine("The strategy hasn't been installing");
                return;
            }
            _strategy.DoAlgorithm(inputString);
        }
    }
}
