using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.paused
{
    public class PausedQuarterCapComplexShape : AbstractComplexShape, ComplexShape
    {

        public PausedQuarterCapComplexShape()
        {
            name = "PausedQuarterComplexShape";
            PausedQuarterCapComplexShape.shapeName = name;
            period = Math.PI * 4;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % ((Math.PI * 6) + (0)));

            if (circleAngle > 0 && circleAngle <= (Math.PI))
            {   // 0 -> 1 pause 1
                p = drawShape(length, circleModifier, 0, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle > (Math.PI) && circleAngle <= ((Math.PI) + (Math.PI / 2)))
            {   // 1 -> 2 move 1
                p = drawShape(length, circleModifier, realCircleAngle - Math.PI, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle > (Math.PI) + (Math.PI / 2) && circleAngle <= ((Math.PI * 2) + (Math.PI / 2)))
            {   // 2 -> 3 pause 2
                p = drawShape(length, circleModifier, (Math.PI / 2), circleTurnModifier);
                x = p.x;
                if (realCircleAngle < 0) y = p.y * -1;
                else y = p.y;
            }
            else if (circleAngle > (Math.PI * 2) + (Math.PI / 2) && circleAngle <= ((Math.PI * 2) + (Math.PI)))
            {   // 3 -> 4 move 2
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI * 2), circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle > (Math.PI * 3) + (0) && circleAngle <= ((Math.PI * 3) + (Math.PI)))
            {   // 4 -> 5 pause 3
                p = drawShape(length, circleModifier, Math.PI, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle > (Math.PI * 4) && circleAngle <= ((Math.PI * 4) + (Math.PI / 2)))
            {   // 5 -> 6 move 3
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI * 3), circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle > (Math.PI * 4) + (Math.PI / 2) && circleAngle <= ((Math.PI * 5) + (Math.PI / 2)))
            {   // 4 -> 5 pause 4
                p = drawShape(length, circleModifier, (Math.PI / 2), circleTurnModifier);
                x = p.x;
                if (realCircleAngle < 0) y = p.y;
                else y = p.y * -1;
            }
            else if (circleAngle > (Math.PI * 5) + (Math.PI / 2) && circleAngle <= ((Math.PI * 6)))
            {   // 5 -> 6 move 4
                p = drawShape(length, circleModifier, realCircleAngle - ((Math.PI * 4)), circleTurnModifier);
                y = p.y;
                x = p.x;
            }

            p.x = (int)x;
            p.y = (int)y;

            return p;
        }

    }
}
