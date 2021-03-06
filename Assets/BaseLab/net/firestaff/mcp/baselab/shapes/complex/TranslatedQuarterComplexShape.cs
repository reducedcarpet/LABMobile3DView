using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class TranslatedQuarterComplexShape : AbstractComplexShape, ComplexShape
    {

        public TranslatedQuarterComplexShape()
        {
            name = "TranslatedQuarterComplexShape";
            TranslatedQuarterComplexShape.shapeName = name;
            period = Math.PI * 6;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % period);

            if (circleAngle >= 0 && circleAngle <= (Math.PI))
            {   // 0 -> 1 slide 1
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = 0;
                //System.out.println("slide: " + realCircleAngle + " :: " + circleAngle);
            }
            else if (circleAngle > (Math.PI) && circleAngle <= ((Math.PI) + (Math.PI / 2)))
            {   // 1 -> 2 move 1
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle > (Math.PI) + (Math.PI / 2) && circleAngle <= ((Math.PI * 2) + (Math.PI / 2)))
            {   // 2 -> 3 pause 2
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                y = p.y;
                x = 0;
            }
            else if (circleAngle > (Math.PI * 2) + (Math.PI / 2) && circleAngle <= ((Math.PI * 2) + (Math.PI)))
            {   // 3 -> 4 move 2
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle > (Math.PI * 3) && circleAngle <= ((Math.PI * 3) + (Math.PI)))
            {   // 4 -> 5 pause 3
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = 0;
            }
            else if (circleAngle > (Math.PI * 4) && circleAngle <= ((Math.PI * 4) + (Math.PI / 2)))
            {   // 5 -> 6 move 3
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle > (Math.PI * 4) + (Math.PI / 2) && circleAngle <= ((Math.PI * 5) + (Math.PI / 2)))
            {   // 4 -> 5 pause 4
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = 0;
                y = p.y;
            }
            else if (circleAngle > (Math.PI * 5) + (Math.PI / 2) && circleAngle <= ((Math.PI * 6)))
            {   // 5 -> 6 move 4
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            }

            p.x = x;
            p.y = y;

            return p;
        }

    }
}
