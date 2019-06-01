using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    class Number
    {
        private int number;

        public Number(int number)
        {
            this.number = number;
        }

        public int GetNumber()
        {
            return number;
        }
    }
}
