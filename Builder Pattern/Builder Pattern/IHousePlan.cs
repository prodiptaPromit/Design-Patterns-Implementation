using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    interface IHousePlan
    {
        void SetBasement(string basement);
        void SetStructure(string structure);
        void SetRoof(string roof);
        void SetInterrior(string interrior);
    }
}
