using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class ExtraSauce:AExtraServings
    {
        public ExtraSauce(IPizza aPizza):base(aPizza)
        {

        }

        public override string Description()
        {
            return base.Description() + " With Extra Sauce";
        }

        public override int Bill()
        {
            return base.Bill() + 100;
        }
    }
}
