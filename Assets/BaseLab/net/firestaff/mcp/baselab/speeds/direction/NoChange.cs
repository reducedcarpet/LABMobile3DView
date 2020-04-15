using System;

namespace net.firestaff.mcp.baselab.speeds.direction
{

    public class NoChange : Direction
    {

        public int updateAngle(double angle, int direction, double mod)
        {
            return direction;
        }
        public string getName()
        {
            return "NoChange";
        }
    }
}
