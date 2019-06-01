using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    abstract class AVehicle
    {
        public int capacityPerson { get; set; }
        public int capacityWeight { get; set; }

        public abstract void Info();
        public abstract void Move();
    }
}
