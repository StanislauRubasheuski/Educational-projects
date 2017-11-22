using System;

namespace CallEncapsulation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light kitchenLight = new Light("Кухне");
            Light livingRoomLight = new Light("Жилой комнате");
            GarageDoor door = new GarageDoor();
            Stereo stereo = new Stereo();

            LightOnCommand lightOnKitchen = new LightOnCommand(kitchenLight);
            LightOffCommand lightOffKitchen = new LightOffCommand(kitchenLight);
            LightOnCommand lightOnLivingRoom = new LightOnCommand(livingRoomLight);
            LightOffCommand lightOffLivingRoom = new LightOffCommand(livingRoomLight);

            GarageDoorOpen doorOn = new GarageDoorOpen(door);
            GarageDoorDownCommand doorOff = new GarageDoorDownCommand(door);

            StereoOnWithCDCommand stereoOn = new StereoOnWithCDCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            CeilingFan ceilingFan = new CeilingFan("Спальня");
            CeilingFanHIGHspeedCommand ceilingFanHigh = new CeilingFanHIGHspeedCommand(ceilingFan);
            CeilingFanMEDIUMspeedCommand ceilingFanMedium = new CeilingFanMEDIUMspeedCommand(ceilingFan);
            CeilingFanOFFcommand ceilingFanOff = new CeilingFanOFFcommand(ceilingFan);
            Command[] partyOn = { lightOnKitchen, lightOnLivingRoom, doorOn, stereoOn };
            Command[] partyOff = { lightOffKitchen, lightOffLivingRoom, doorOff, stereoOff };
            MacroCommand macroOn = new MacroCommand(partyOn);
            MacroCommand macroOff = new MacroCommand(partyOff);

            remoteControl.SetCommand(0, lightOnKitchen, lightOffKitchen);
            remoteControl.SetCommand(1, lightOnLivingRoom, lightOffLivingRoom);
            remoteControl.SetCommand(2, doorOn, doorOff);
            remoteControl.SetCommand(3, stereoOn, stereoOff);
            remoteControl.SetCommand(4, ceilingFanHigh, ceilingFanOff);
            remoteControl.SetCommand(5, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(6, macroOn, macroOff);

            Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPressed();
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);
            remoteControl.UndoButtonWasPressed();
            Console.WriteLine(ceilingFan.GetSpeed());
            remoteControl.OnButtonWasPushed(6);
            remoteControl.OffButtonWasPushed(6);
            remoteControl.UndoButtonWasPressed();

        }
    }
}
