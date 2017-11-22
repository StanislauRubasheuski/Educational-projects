using System;
namespace CallEncapsulation
{
    public class CeilingFanOFFcommand: Command
    {
        CeilingFan ceilingFan;
        int prevSpeed;

        public CeilingFanOFFcommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            prevSpeed = ceilingFan.GetSpeed();
            ceilingFan.Off();
        }

        public void Undo()
        {
            if (prevSpeed == CeilingFan.HIGH)
                ceilingFan.High();
            else if (prevSpeed == CeilingFan.MEDIUM)
                ceilingFan.Medium();
            else if (prevSpeed == CeilingFan.LOW)
                ceilingFan.Low();
            else if (prevSpeed == CeilingFan.OFF)
                ceilingFan.Off();
        }
    }
}
