using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    class Karen : IPerson
    {
        public int Age()
        {
            return 18;
        }

        public string Name()
        {
            return "Her name is Karen";
        }
    }
}
