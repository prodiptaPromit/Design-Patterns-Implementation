using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class ExtraChese:AExtraServings
    {
        public ExtraChese(IPizza aPizza):base(aPizza)
        {

        }

        public override string Description()
        {
            return base.Description()+" With Extra Chese";
        }

        public override int Bill()
        {
            return base.Bill()+200;
        }
    }
}
