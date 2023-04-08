using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    public class NetResource : INetResource
    {
        public int GetStatus()
        {
            Thread.Sleep(5000);
            List<int> statuses = new List<int>() { 200, 400, 500 };
            return statuses[new Random().Next(0,3)];
        }

    }
}
