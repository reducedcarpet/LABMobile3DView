using System;

namespace net.firestaff.mcp.baselab.speeds.speed
{

    public class ThreeQuarterCC : AbstractSpeed, Speed
    {

        override public string getName()
        {
            return "ThreeQuarterCC";
        }

        override public double updateAngle(double angle, double propAngle, double increment, double speed, int direction, double mod)
        {
            mod = mod % (Math.PI * 2);
            return SpeedHelper.updateSymmetricOnOffAngle(angle, propAngle, increment, speed, direction, (Math.PI + (Math.PI / 2)), mod);
        }

        override public Speed copy()
        {
            Speed copy = new ThreeQuarterCC();
            copy.setLowerSpeed(lowerSpeed);
            copy.setUpperSpeed(upperSpeed);
            return copy;
        }
    }
}
