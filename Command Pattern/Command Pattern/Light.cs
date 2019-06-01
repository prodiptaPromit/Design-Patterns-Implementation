using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }
        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }
}
