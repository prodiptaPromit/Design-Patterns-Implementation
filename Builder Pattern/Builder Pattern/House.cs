using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern
{
    class House : IHousePlan
    {
        private string basement;
        private string structure;
        private string roof;
        private string interrior;

        public void SetBasement(string basement)
        {
            this.basement = basement;
        }

        public void SetInterrior(string interrior)
        {
            this.interrior = interrior;
        }

        public void SetRoof(string roof)
        {
            this.roof = roof;
        }

        public void SetStructure(string structure)
        {
            this.structure = structure;
        }
    }
}
