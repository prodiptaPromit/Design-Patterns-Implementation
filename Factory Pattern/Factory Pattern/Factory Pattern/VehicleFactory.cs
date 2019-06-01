using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class VehicleFactory
    {
        

        public VehicleFactory()
        {

        }

        public AVehicle GetVehicle(string type)
        {
            if (type == "Truck")
                return new Truck();
            else if (type == "Bus")
                return new Bus();
            else if (type == "MoBike")
                return new MoBike();
            else
                return null;
        }

        public AVehicle GetVehicle(int capacity)
        {
            if (capacity>2000 && capacity<=3000 )
                return new Truck();
            else if (capacity>200 && capacity<=2000)
                return new Bus();
            else if (capacity>0 && capacity<=200)
                return new MoBike();
            else
                return null;
        }
    }
}
