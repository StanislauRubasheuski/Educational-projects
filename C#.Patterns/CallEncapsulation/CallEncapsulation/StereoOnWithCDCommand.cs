using System;
namespace CallEncapsulation
{
    public class StereoOnWithCDCommand: Command
    {
        Stereo stereo;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.Volume = 11;
        }

        public void Undo()
        {
            stereo.Off();
        }
    }
}
