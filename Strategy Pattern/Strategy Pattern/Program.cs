using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchStrategy searchStrategy = new SearchStrategy(new LinearSearchStrategy(7));
            searchStrategy.ExecuteSearch();

            searchStrategy = new SearchStrategy(new BinarySearchStrategy(25));
            searchStrategy.ExecuteSearch();

            Console.ReadKey();
        }
    }
}
