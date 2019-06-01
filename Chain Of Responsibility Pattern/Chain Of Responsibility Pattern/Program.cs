using System;

namespace Chain_Of_Responsibility_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IChain chain1 = new NegativeProcessor();
            IChain chain2 = new ZeroProcessor();
            IChain chain3 = new PositiveProcessor();

            chain1.SetNext(chain2);
            chain2.SetNext(chain3);

            chain1.Process(new Number(7));
            chain1.Process(new Number(-5));
            chain1.Process(new Number(0));
            chain1.Process(new Number(16));
            chain1.Process(new Number(-25));

            Console.ReadKey();
        }
    }
}
