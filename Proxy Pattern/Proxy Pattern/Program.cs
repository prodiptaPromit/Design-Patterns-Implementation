using System;

namespace Proxy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IInternet internet = new ProxyInternet();

            internet.ConnectTo("no-idea.com");
            internet.ConnectTo("google.com");

            Console.ReadKey();
        }
    }
}
