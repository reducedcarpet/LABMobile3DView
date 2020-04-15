using System;

namespace net.firestaff.mcp.baselab.speeds.speed
{

    public class HalfCC : AbstractSpeed, Speed
    {

        override public string getName()
        {
            return "HalfCC";
        }

        override public double updateAngle(double angle, double propAngle, double increment, double speed, int direction, double mod)
        {
            //if(lowerSpeed == 0)
            return SpeedHelper.updateSymmetricOnOffAngle(angle, propAngle, increment, speed, direction, (Math.PI), mod);
            //else return SpeedHelper.updateSymmetricPolySpeedAngle(upperSpeed, lowerSpeed, angle, propAngle, increment, speed, direction, (Math.PI), mod);
        }

        override public Speed copy()
        {
            Speed copy = new HalfCC();
            copy.setLowerSpeed(lowerSpeed);
            copy.setUpperSpeed(upperSpeed);
            return copy;
        }
    }
}
