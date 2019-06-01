using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    class Sparrow : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public void MakeSound()
        {
            Console.WriteLine("Making some sounds");
        }
    }
}
