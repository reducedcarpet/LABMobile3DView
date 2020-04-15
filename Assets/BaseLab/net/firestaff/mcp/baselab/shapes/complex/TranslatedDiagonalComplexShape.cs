using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class TranslatedDiagonalComplexShape : AbstractComplexShape, ComplexShape
    {

        public TranslatedDiagonalComplexShape()
        {
            name = "TranslatedDiagonalComplexShape";
            TranslatedDiagonalComplexShape.shapeName = name;
            period = Math.PI * 3;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % (Math.PI * 3));
            double fakeAngle = realCircleAngle % (Math.PI * 3);

            if (circleAngle <= (Math.PI))
            {   // 0 -> 1 slide 1
                p = drawShape(length, circleModifier, fakeAngle, circleTurnModifier);
                x = p.x;
                y = 0;
            }
            else if (circleAngle <= (Math.PI + (Math.PI / 2)))
            {   // 1 -> 2 move 1
                p = drawShape(length, circleModifier, fakeAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            }
            else if (circleAngle <= (Math.PI * 2) + (Math.PI / 2))
            {   // 2 -> 3 pause 2
                p = drawShape(length, circleModifier, fakeAngle, circleTurnModifier);
                y = p.y;
                x = 0;
            }
            else if (circleAngle <= (Math.PI * 3))
            {   // 4 -> 5 pause 3
                p = drawShape(length, circleModifier, fakeAngle + (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            }


            p.x = x;
            p.y = y;

            return p;
        }
    }
}
