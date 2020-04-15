using System;

namespace net.firestaff.mcp.baselab.speeds.speed
{

    public class HalfQuarterCC : AbstractSpeed, Speed
    {

        override public string getName()
        {
            return "HalfQuarterCC";
        }

        override public double updateAngle(double angle, double propAngle, double increment, double speed, int direction, double mod)
        {
            //mod = mod % (Math.PI / 2);
            return SpeedHelper.updateAsymmetricOnOffAngle(angle, propAngle, increment, speed, direction, (Math.PI), (Math.PI / 2), mod);
        }

        override public Speed copy()
        {
            Speed copy = new HalfQuarterCC();
            copy.setLowerSpeed(lowerSpeed);
            copy.setUpperSpeed(upperSpeed);
            return copy;
        }
    }
}
