using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class LinearSearchStrategy:ISearchStrategy
    {
        private int data;
        private Numbers numbers;

        public LinearSearchStrategy(int data)
        {
            Init();
            this.data = data;
        }

        private void Init()
        {
            numbers = new Numbers();            
        }

        public string ExecuteSearch()
        {
            foreach(var item in numbers.GetNumbers())
            {
                if (data == item)
                {
                    return "Item available";
                }                  
            }
            return "Item unavailable";
        }
    }
}
