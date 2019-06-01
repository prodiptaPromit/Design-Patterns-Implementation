using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class LightOnCommand:ICommand
    {
        Light light;
 
        public LightOnCommand(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.On();
        }
    }
}
