using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Order1();
            Order2();
            Order3();
            Order4();

            Console.ReadKey();
        }

        static void Order1()
        {
            IPizza pizza = new FourSeason();
            AExtraServings servings = new ExtraChese(pizza);

            Console.WriteLine("Order Title: " + servings.Description());
            Console.WriteLine("Bill: " + servings.Bill() + "\n\n\n");

        }

        static void Order2()
        {
            IPizza pizza = new CheseLover();
            AExtraServings servings = new ExtraSauce(pizza);

            Console.WriteLine("Order Title: " + servings.Description());
            Console.WriteLine("Bill: " + servings.Bill() + "\n\n\n");
        }

        static void Order3()
        {
            IPizza pizza = new TomatoPie();
            AExtraServings servings = new ExtraTopping(pizza);

            Console.WriteLine("Order Title: " + servings.Description());
            Console.WriteLine("Bill: " + servings.Bill() + "\n\n\n");
        }

        static void Order4()
        {
            IPizza pizza = new FourSeason();
            pizza = new ExtraTopping(pizza);
            pizza = new ExtraSauce(pizza);
            Console.WriteLine("Order Title: " + pizza.Description());
            Console.WriteLine("Bill: " + pizza.Bill() + "\n\n\n");
        }
    }
}
