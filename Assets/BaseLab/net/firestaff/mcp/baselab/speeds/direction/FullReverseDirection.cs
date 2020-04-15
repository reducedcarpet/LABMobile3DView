using System;

namespace net.firestaff.mcp.baselab.speeds.direction
{
    public class FullReverseDirection : Direction
    {


        public int updateAngle(double angle, int direction, double mod)
        {
            return DirectionHelper.updateAsymmetricOnOffAngle(angle, direction, Math.PI * 2, mod);
            //return 1;
        }

        public string getName()
        {
            return "FullReverse";
        }
    }
}
