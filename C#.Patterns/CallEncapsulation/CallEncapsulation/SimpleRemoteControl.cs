﻿using System;
namespace CallEncapsulation
{
    public class SimpleRemoteControl
    {
        Command slot;

        public void SetCommand(Command command)
        {
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
