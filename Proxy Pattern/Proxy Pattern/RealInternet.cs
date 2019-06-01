using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    class RealInternet : IInternet
    {
        public void ConnectTo(string serverHost)
        {
            Console.WriteLine("Connecting to "+serverHost);
        }
    }
}
