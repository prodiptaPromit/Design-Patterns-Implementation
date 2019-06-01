using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Person_1();
            Person_2();
            Person_3();
            Person_4();

            Console.ReadKey();
        }

        static void Person_1()
        {
            IPerson person = new Karen();
            APersonDecorator decorator = new Lipstick(person);

            Console.WriteLine(decorator.Name());
            Console.WriteLine("Age: " + decorator.Age());
        }

        static void Person_2()
        {
            IPerson person = new Claire();
            APersonDecorator decorator = new EyeLiner(person);

            Console.WriteLine(decorator.Name());
            Console.WriteLine("Age: " + decorator.Age());
        }

        static void Person_3()
        {
            IPerson person = new Rach();
            APersonDecorator decorator = new Kajol(person);

            //person = new Lipstick(person);
            Console.WriteLine(decorator.Name());
            Console.WriteLine("Age: " + decorator.Age());
        }

        static void Person_4()
        {
            IPerson person = new Rach();
            person = new Kajol(person);

            person = new Lipstick(person);
            person = new EyeLiner(person);
            Console.WriteLine(person.Name());
            Console.WriteLine("Age: " + person.Age());
        }
    }
}
