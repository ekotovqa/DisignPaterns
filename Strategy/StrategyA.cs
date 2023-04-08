using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class StrategyA : IStrategy
    {
        public void DoAlgorithm(string inputString)
        {
            Console.WriteLine(inputString);
        }
    }
}
