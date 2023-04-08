using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Strategy
{
    public interface IStrategy
    {
        void DoAlgorithm(string inputString);
    }
}
