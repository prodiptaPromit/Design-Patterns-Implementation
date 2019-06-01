using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop
{
    internal abstract class APersonDecorator:IPerson
    {
        IPerson person;
        public APersonDecorator(IPerson person)
        {
            this.person = person;
        }

        public virtual int Age()
        {
            return person.Age();
        }

        public virtual string Name()
        {
            return person.Name();
        }
    }
}
