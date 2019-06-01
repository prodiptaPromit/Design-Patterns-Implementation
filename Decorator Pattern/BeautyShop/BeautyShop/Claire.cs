using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    class Claire:IPerson
    {
        public int Age()
        {
            return 20;
        }

        public string Name()
        {
            return "Her name is Claire";
        }
    }
}
