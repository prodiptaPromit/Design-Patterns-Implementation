using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class FourSeason : IPizza
    {
        public int Bill()
        {
            return 800;
        }

        public string Description()
        {
            return "Four Season Pizza";
        }
    }
}
