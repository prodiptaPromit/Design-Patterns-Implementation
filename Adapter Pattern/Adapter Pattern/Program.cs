using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBird sparrow = new Sparrow();
            IToyDuck toyDuck = new PlasticToyDuck();
            IToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow:");
            sparrow.Fly();
            sparrow.MakeSound();

            Console.WriteLine("\n\n\nToy Duck:");
            toyDuck.Squeak();

            Console.WriteLine("\n\n\nBird Adapter:");
            birdAdapter.Squeak();

            Console.ReadKey();
        }
    }
}
