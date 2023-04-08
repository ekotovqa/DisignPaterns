using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ConcreteBuilder1 : IBuilder
    {

        private Product _product = new Product(); 
        public void BuildPartA()
        {
            _product.PartA = "PartA";
        }

        public void BuildPartB()
        {
            _product.PartB = "PartB";
        }

        public void BuildPartC()
        {
            _product.PartC = "PartC";
        }

        public Product GetProduct()
        {
            Product result = _product;
            _product = new Product();
            return result;
        }
    }
}
