using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Bus:AVehicle
    {
        public Bus()
        {
            capacityPerson = 40;
            capacityWeight = 2000;
        }
        public override void Info()
        {
            Console.WriteLine("Vehicle Type: Bus");
            Console.WriteLine("Passanger Capacity: "+ capacityPerson);
            Console.WriteLine("Weight Capacity: "+ capacityWeight);
        }
        public override void Move()
        {
            Console.WriteLine("Bus is moving\n\n\n");
        }
    }
}
