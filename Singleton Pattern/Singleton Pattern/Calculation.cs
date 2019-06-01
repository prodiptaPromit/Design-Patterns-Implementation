using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    sealed class Calculation
    {
        private static Calculation instance;
        public int value1 { get; set; }
        public int value2 { get; set; }

        private Calculation()
        {

        }

        public static Calculation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculation();
                }
                return instance;
            }
        }

        public int Addition()
        {
            return value1 + value2;
        }

        public int Subtraction()
        {
            return value1 - value2;
        }

        public int Multiplication()
        {
            return value1 * value2;
        }

        public double Division()
        {
            if (value1 > value2)
                return (double)value1 / (double)value2;
            else
                return (double)value2 / (double)value1;
        }

    }
}
