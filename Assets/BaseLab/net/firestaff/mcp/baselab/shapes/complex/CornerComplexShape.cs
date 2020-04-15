using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class CornerComplexShape : AbstractComplexShape, ComplexShape
    {

        public CornerComplexShape()
        {
            name = "CornerComplexShape";
            CornerComplexShape.shapeName = name;
        }


        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            double fakeAngle = Math.Abs(circleAngle % ((Math.PI) + (Math.PI / 2)));

            p = baseShape.draw(length, circleModifier, fakeAngle, circleTurnModifier);
            y = p.y;
            x = p.x;

            Point b = baseShape.draw(length, circleModifier, (fakeAngle - (Math.PI)), circleTurnModifier);
            double y1 = b.y;
            double x1 = b.x;

            if (fakeAngle <= (Math.PI / 2))
            {
                p = baseShape.draw(length, circleModifier, fakeAngle - (Math.PI / 2), circleTurnModifier);
                y = p.y;
                x = 0;
            }
            else if (fakeAngle <= (Math.PI))
            {
                p = reverse(p);
                x = p.x;
                y = 0;
            }
            else
            {
                b = reverse(b);
                y = b.y;
                x = b.x;
            }

            p.x = x;
            p.y = y;

            return p;
        }

    }
}
