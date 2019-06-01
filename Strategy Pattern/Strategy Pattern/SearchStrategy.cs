using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class SearchStrategy
    {
        ISearchStrategy searchStrategy;

        public SearchStrategy(ISearchStrategy searchStrategy)
        {
            this.searchStrategy = searchStrategy;
        }

        public void ExecuteSearch()
        {
            Console.WriteLine(searchStrategy.ExecuteSearch());
        }
    }
}
