using System;

namespace net.firestaff.mcp.baselab.shapes.zaxis
{

    public class ZCircle : AbstractZShape
    {

        public ZCircle()
        {
            name = "ZCircle";
        }

        override public double draw(double circleAngle, double zMod)
        {
            circleAngle = circleAngle + zMod;
            double x = Math.Cos(circleAngle);

            return x;
        }
    }
}
