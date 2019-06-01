using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    internal abstract class AExtraServings:IPizza
    {
        private IPizza iPizza;

        public AExtraServings(IPizza aPizza)
        {
            iPizza = aPizza;
        }

        public virtual int Bill()
        {
            return iPizza.Bill();
        }

        public virtual string Description()
        {
            return iPizza.Description();
        }
    }
}
