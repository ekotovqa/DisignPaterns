using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class StrategyB : IStrategy
    {
        public void DoAlgorithm(string inputString)
        {

            Console.WriteLine(new string(inputString.Reverse().ToArray()));
        }
    }
}
