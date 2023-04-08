using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class NetResourceProxy : INetResource
    {
        private readonly NetResource _netResource;
        private int _status = 0;

        public NetResourceProxy(NetResource netResource)
        {
            _netResource= netResource;
        }
        public int GetStatus()
        {
            if (_status == 0) 
            {
                Console.Clear();
                Console.WriteLine($"{DateTime.Now} GetStatus");
                _status = _netResource.GetStatus();
            }              
            return _status;
        }
    }
}
