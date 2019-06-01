using System;

namespace Command_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControll remoteControll = new RemoteControll(new LightOnCommand(new Light()));
            remoteControll.ButtonPressed();
            remoteControll = new RemoteControll(new LightOffCommand(new Light()));
            remoteControll.ButtonPressed();

            Console.ReadKey();
        }
    }
}
