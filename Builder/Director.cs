using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private readonly IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void BuildFullProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }

        public void BuildMinimalProduct()
        {
            _builder.BuildPartA();
        }
    }
}
