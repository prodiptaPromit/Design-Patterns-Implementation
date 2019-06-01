using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    interface IHouseBuilder
    {
        void BuildBasement();
        void BuildStructure();
        void BuildRoof();
        void BuildInterrior();
        string GetHouse();
    }
}
