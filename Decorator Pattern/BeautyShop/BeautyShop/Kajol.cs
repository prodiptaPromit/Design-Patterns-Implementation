using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    class Kajol:APersonDecorator
    {
        public Kajol(IPerson person):base(person)
        {

        }

        public override string Name()
        {
            return base.Name() + " With Kajol.";
        }

        public override int Age()
        {
            return base.Age() - 3;
        }
    }
}
