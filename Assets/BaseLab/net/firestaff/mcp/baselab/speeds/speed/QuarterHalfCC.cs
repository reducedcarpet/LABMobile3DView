using System;

namespace net.firestaff.mcp.baselab.speeds.speed
{

    public class QuarterHalfCC : AbstractSpeed, Speed
    {

        override public string getName()
        {
            return "QuarterHalfCC";
        }

        override public double updateAngle(double angle, double propAngle, double increment, double speed, int direction, double mod)
        {
            //mod = mod % (Math.PI / 2);
            return SpeedHelper.updateAsymmetricOnOffAngle(angle, propAngle, increment, speed, direction, (Math.PI / 2), (Math.PI), mod);
        }

        override public Speed copy()
        {
            Speed copy = new QuarterHalfCC();
            copy.setLowerSpeed(lowerSpeed);
            copy.setUpperSpeed(upperSpeed);
            return copy;
        }
    }
}

