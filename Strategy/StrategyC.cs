using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class StrategyC : IStrategy
    {
        public void DoAlgorithm(string inputString)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in inputString)
            {
                result.Append(c + " ");
            }
            Console.WriteLine(result.ToString());
        }
    }
}
