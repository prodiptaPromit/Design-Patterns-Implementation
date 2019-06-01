using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    class IglooHouseBuilder : IHouseBuilder
    {
        private House house;

        public IglooHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            house.SetBasement("Ice Bars");
        }

        public void BuildInterrior()
        {
            house.SetInterrior("Ice carving");
        }

        public void BuildRoof()
        {
            house.SetRoof("Ice dome");
        }

        public void BuildStructure()
        {
            house.SetStructure("Ice blocks");
        }

        public string GetHouse()
        {
            return "Igloo House";
        }
    }
}
