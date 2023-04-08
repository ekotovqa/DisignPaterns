using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string PartC { get; set; }

        public List<string> GetParts()
        {
            return new List<string> { PartA, PartB, PartC };
        }
    }
}
