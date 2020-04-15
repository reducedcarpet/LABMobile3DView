using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.paused
{
    public class PausedHalfComplexShape : PausedHelper
    {

        public PausedHalfComplexShape()
        {
            name = "PausedHalfComplexShape";
            PausedHalfComplexShape.shapeName = name;
            period = Math.PI * 6;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {
            return base.drawPaused(length, circleModifier, realCircleAngle, circleTurnModifier, (Math.PI * 2), 2);
        }
        /*
        override public Point draw(double length, double circleModifier, double realCircleAngle,  double circleTurnModifier) {

            double circleAngle = Math.Abs (realCircleAngle % ((Math.PI * 4)));

            if(circleAngle > 0 && circleAngle <= (Math.PI))
            {   // 0 -> 1 pause
                p = drawShape(length, circleModifier, Math.PI, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if(circleAngle > (Math.PI) && circleAngle <= ((Math.PI) + Math.PI))
            {   // 1 -> 3 down
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if(circleAngle > (Math.PI) + Math.PI && circleAngle <= ((Math.PI * 3) ))
            {   // 3 -> 4 pause
                p = drawShape(length, circleModifier, 0, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else
            {   // 4 -> 6
                p = drawShape(length, circleModifier, realCircleAngle + Math.PI, circleTurnModifier);
                y = p.y;
                x = p.x;
            }


            p.x = (int)x;
            p.y = (int)y;

            return p;
        }
        /**/

    }
}
