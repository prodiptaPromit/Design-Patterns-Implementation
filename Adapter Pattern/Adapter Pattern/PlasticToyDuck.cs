using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
