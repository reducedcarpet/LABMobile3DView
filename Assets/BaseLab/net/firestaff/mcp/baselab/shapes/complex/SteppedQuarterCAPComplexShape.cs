using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class SteppedQuarterCAPComplexShape : AbstractComplexShape, ComplexShape
    {

        public SteppedQuarterCAPComplexShape()
        {
            name = "SteppedQuarterCAPComplexShape";
            SteppedQuarterCAPComplexShape.shapeName = name;
            period = Math.PI * 6;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % period);

            if (circleAngle < (Math.PI / 2))
            {   // 0 -> 1 slide 1
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle < Math.PI)
            {   // 1 -> 2 move 1
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle < (Math.PI * 2))
            {   // 2 -> 3 pause 2
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;

            }


            else if (circleAngle < ((Math.PI * 2) + (Math.PI / 2)))
            {   // 1 -> 2 move 1
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle < (Math.PI * 3) + (Math.PI / 2))
            {   // 2 -> 3 pause 2
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                x = p.x;
                y = p.y;

            }


            else if (circleAngle < ((Math.PI * 4)))
            {   // 1 -> 2 move 1
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle < (Math.PI * 5))
            {   // 2 -> 3 pause 2
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;

            }

            else if (circleAngle < ((Math.PI * 5) + (Math.PI / 2)))
            {   // 1 -> 2 move 1
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle < (Math.PI * 6))
            {   // 2 -> 3 pause 2
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                x = p.x;
                y = p.y;

            }

            p.x = x;
            p.y = (int)y;

            return p;
        }
    }
}
