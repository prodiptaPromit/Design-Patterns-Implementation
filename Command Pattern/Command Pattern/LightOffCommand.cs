using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class LightOffCommand:ICommand
    {
        Light light;
       
        public LightOffCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.Off();
        }
    }
}
