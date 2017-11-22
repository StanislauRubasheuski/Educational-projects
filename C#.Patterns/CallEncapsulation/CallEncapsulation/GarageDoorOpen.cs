using System;
namespace CallEncapsulation
{
    public class GarageDoorOpen: Command
    {
        GarageDoor door;

        public GarageDoorOpen(GarageDoor door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Up();
        }

        public void Undo()
        {
            door.Down();
        }
    }
}
