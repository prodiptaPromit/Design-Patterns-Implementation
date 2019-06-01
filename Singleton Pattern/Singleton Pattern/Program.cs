using System;

namespace Singleton_Pattern
{
    class Program
    {       
        static void Main(string[] args)
        {
            InputData();

            Console.WriteLine("Result of addition statnds " + Calculation.Instance.Addition());
            Console.WriteLine("Result of suntraction statnds " + Calculation.Instance.Subtraction());
            Console.WriteLine("Result of multiplication statnds " + Calculation.Instance.Multiplication());
            Console.WriteLine("Result of division statnds " + Calculation.Instance.Division());

            Console.ReadKey();
        }

        private static void InputData()
        {
            Calculation.Instance.value1 = int.Parse(Console.ReadLine());
            Calculation.Instance.value2 = int.Parse(Console.ReadLine());
        }
    }
}
