using System;

using net.firestaff.mcp.baselab.speeds.acceleration;

namespace net.firestaff.mcp.baselab.speeds.acceleration
{
    public class ZeroAcceleration : Acceleration {
        public double updateAngle(double angle, double increment, double speed, int direction) {
            return 0;
        }

        public void reset(int dir) { }
    }
}
