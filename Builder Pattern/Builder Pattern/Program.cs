using System;

namespace Builder_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildHouse(new Engineer(new IglooHouseBuilder()));
            BuildHouse(new Engineer(new TipiHouseBuilder()));

            Console.ReadKey();
        }

        static void BuildHouse(Engineer engineer)
        {
            engineer.ConstructHouse();
            var house = engineer.GetHouse();

            Console.WriteLine("Builder constructed " + house);
        }
    }
}
