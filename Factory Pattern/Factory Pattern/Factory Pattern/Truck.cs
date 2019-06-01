using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class Truck:AVehicle
    {       
        public Truck()
        {
            capacityPerson = 3;
            capacityWeight = 3000;
        }
        public override void Info()
        {
            Console.WriteLine("Vehicle Type: Truck");
            Console.WriteLine("Passanger Capacity: "+ capacityPerson);
            Console.WriteLine("Weight Capacity: "+ capacityWeight);
        }
        public override void Move()
        {
            Console.WriteLine("Truck is moving\n\n\n");
        }
    }
}
