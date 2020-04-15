using System;

using net.firestaff.mcp.baselab.speeds.speed;


namespace net.firestaff.mcp.baselab.speeds.speed
{
    public class ConstantSpeed : AbstractSpeed, Speed
    {

        override public double updateAngle(double angle, double propAngle, double increment, double speed, int direction, double mod)
        {
            return 0;
        }

        override public string getName()
        {
            return "Constant";
        }

        override public Speed copy()
        {
            Speed copy = new ConstantSpeed();
            copy.setLowerSpeed(lowerSpeed);
            copy.setUpperSpeed(upperSpeed);
            return copy;
        }
    }
}
