using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class MoBike: AVehicle
    {

        public MoBike()
        {
            capacityPerson = 2;
            capacityWeight = 200;
        }
        public override void Info()
        {
            Console.WriteLine("Vehicle Type: MoBike");
            Console.WriteLine("Passanger Capacity: "+ capacityPerson);
            Console.WriteLine("Weight Capacity: "+ capacityWeight);
        }
        public override void Move()
        {
            Console.WriteLine("MoBike is moving\n\n\n");
        }
    }
}
