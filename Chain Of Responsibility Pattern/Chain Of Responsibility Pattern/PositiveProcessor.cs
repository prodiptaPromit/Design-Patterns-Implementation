using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    class PositiveProcessor:IChain
    {
        private IChain nextInChain;

        public void Process(Number request)
        {
            if (request.GetNumber() > 0)
            {
                Console.WriteLine("The number "+request.GetNumber()+" is positive");
            }
            else
            {
                nextInChain.Process(request);
            }
        }

        public void SetNext(IChain nextInChain)
        {
            this.nextInChain = nextInChain;
        }
    }
}
