using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class TomatoPie:IPizza
    {
        public int Bill()
        {
            return 500;
        }

        public string Description()
        {
            return "Tomato Pie Pizza";
        }
    }
}
