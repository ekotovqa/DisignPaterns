using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisignPaterns
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {
            
        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void SomeBusinessLogic()
        {

        }
    }
}
