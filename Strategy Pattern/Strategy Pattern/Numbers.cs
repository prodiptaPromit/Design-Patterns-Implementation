using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class Numbers
    {
        private List<int> numbers;

        public Numbers()
        {
            numbers = new List<int>();

            numbers.Add(12);
            numbers.Add(5);
            numbers.Add(18);
            numbers.Add(7);
            numbers.Add(25);
        }

        public List<int> GetNumbers()
        {
            return numbers;
        }
    }
}
