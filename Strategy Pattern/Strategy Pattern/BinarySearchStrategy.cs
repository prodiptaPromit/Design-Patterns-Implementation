using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class BinarySearchStrategy:ISearchStrategy
    {
        private int data;
        private Numbers numbers;

        public BinarySearchStrategy(int data)
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
            numbers.GetNumbers().Sort();
            if (numbers.GetNumbers().BinarySearch(data) >= 0)
                return "Item available";
            else
                return "Item unavailable";

        }
    }
}
