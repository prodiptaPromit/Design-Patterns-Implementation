using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    class Engineer
    {
        private IHouseBuilder houseBuilder;

        public Engineer(IHouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        public void ConstructHouse()
        {
            houseBuilder.BuildBasement();
            houseBuilder.BuildStructure();
            houseBuilder.BuildRoof();
            houseBuilder.BuildInterrior();
        }

        public string GetHouse()
        {
            return this.houseBuilder.GetHouse();
        }
    }
}
