
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    class BirdAdapter : IToyDuck
    {
        IBird bird;

        public BirdAdapter(IBird bird)
        {
            this.bird = bird;
        }

        public void Squeak()
        {
            bird.MakeSound();
        }
    }
}
