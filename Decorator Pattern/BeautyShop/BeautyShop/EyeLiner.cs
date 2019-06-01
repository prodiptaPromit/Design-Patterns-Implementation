using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    class EyeLiner:APersonDecorator
    {
        public EyeLiner(IPerson person):base(person)
        {

        }

        public override string Name()
        {
            return base.Name() + " using Eyeliner.";
        }

        public override int Age()
        {
            return base.Age() - 1;
        }
    }
}
