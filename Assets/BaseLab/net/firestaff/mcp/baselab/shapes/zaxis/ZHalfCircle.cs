using System;

namespace net.firestaff.mcp.baselab.shapes.zaxis
{

    public class ZHalfCircle : AbstractZShape
    {

        override public double draw(double realCircleAngle, double zMod)
        {
            double x = 0;

            realCircleAngle = realCircleAngle + zMod;
            double circleAngle = Math.Abs(realCircleAngle % ((Math.PI * 4)));
            //circleAngle = circleAngle + ZMod;

            if (circleAngle > 0 && circleAngle <= (Math.PI))
            {   // 0 -> 1 pause
                x = -1;
            }
            else if (circleAngle > (Math.PI) && circleAngle <= (Math.PI * 2))
            {   // 1 -> 3 down
                x = Math.Cos(realCircleAngle);
            }
            else if (circleAngle > (Math.PI * 2) && circleAngle <= (Math.PI * 3))
            {   // 1 -> 3 down
                x = 1;
            }
            else
            {   // 1 -> 3 down
                x = Math.Cos(realCircleAngle - Math.PI);
            }

            return x;
        }
    }
}
