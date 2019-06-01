using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    class RemoteControll
    {
        ICommand command;

        public RemoteControll(ICommand command)
        {
            this.command = command;
        }

        public void ButtonPressed()
        {
            command.Execute();
        }
    }
}
