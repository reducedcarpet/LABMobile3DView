using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.paused
{
    public class PausedFullComplexShape : AbstractComplexShape, ComplexShape
    {

        public PausedFullComplexShape()
        {
            name = "PausedFullComplexShape";
            PausedFullComplexShape.shapeName = name;
            period = Math.PI * 3;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % ((Math.PI * 4)));

            if (circleAngle >= 0 && circleAngle < (Math.PI))
            {   // 0 -> 1 pause
                p = drawShape(length, circleModifier, Math.PI, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle >= (Math.PI) && circleAngle <= ((Math.PI * 3)))
            {   // 1 -> 3 move
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle >= (Math.PI * 3) && circleAngle <= ((Math.PI * 4)))
            {   // 1 -> 3 pause
                p = drawShape(length, circleModifier, Math.PI, circleTurnModifier);
                y = p.y;
                x = p.x;
            }

            p.x = (int)x;
            p.y = (int)y;

            return p;
        }

    }
}
