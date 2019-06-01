using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    class ProxyInternet : IInternet
    {
        private IInternet internet = new RealInternet();
        private static List<string> bannedSites;

        public ProxyInternet()
        {
            bannedSites = new List<string>();
            bannedSites.Add("abc.com");
            bannedSites.Add("no-idea.com");
        }
        

        public void ConnectTo(string serverHost)
        {
            if(bannedSites.Contains(serverHost))
            {
                Console.WriteLine("Access denied");               
            }
            else
            {
                internet.ConnectTo(serverHost);
            }           
        }
    }
}
