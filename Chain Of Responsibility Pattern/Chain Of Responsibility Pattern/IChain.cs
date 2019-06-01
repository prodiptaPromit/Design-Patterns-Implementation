using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_Of_Responsibility_Pattern
{
    interface IChain
    {
        void SetNext(IChain nextInChain);
        void Process(Number request);
    }
}
