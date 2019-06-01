using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    class Lipstick:APersonDecorator
    {
        public Lipstick(IPerson person):base(person)
        {

        }

        public override string Name()
        {
            return base.Name()+" using Lipstick.";
        }

        public override int Age()
        {
            return base.Age()-2;
        }

    }
}
