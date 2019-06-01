using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    interface IInternet
    {
        void ConnectTo(string serverhost);
    }
}
