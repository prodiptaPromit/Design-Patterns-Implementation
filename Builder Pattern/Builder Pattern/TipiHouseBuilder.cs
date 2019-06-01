using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    class TipiHouseBuilder:IHouseBuilder
    {
        private House house;

        public TipiHouseBuilder()
        {
            this.house = new House();
        }

        public void BuildBasement()
        {
            house.SetBasement("Woden poles");
        }

        public void BuildInterrior()
        {
            house.SetInterrior("Fire wood");
        }

        public void BuildRoof()
        {
            house.SetRoof("Wood, caribou and seal skins");
        }

        public void BuildStructure()
        {
            house.SetStructure("Wood and Ice");
        }

        public string GetHouse()
        {
            return "Tipi House";
        }
    }
}
