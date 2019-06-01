using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class CheseLover:IPizza
    {
        public int Bill()
        {
            return 1500;
        }

        public string Description()
        {
            return "Chese Lover Pizza";
        }
    }
}
