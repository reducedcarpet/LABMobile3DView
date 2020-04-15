using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class TranslatedHalfComplexShape : AbstractComplexShape, ComplexShape
    {

        public TranslatedHalfComplexShape()
        {
            name = "TranslatedHalfComplexShape";
            TranslatedHalfComplexShape.shapeName = name;
        }


        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            p = baseShape.draw(length, circleModifier, circleAngle, circleTurnModifier);
            y = p.y;
            x = p.x;

            double fakeAngle = Math.Abs(circleAngle % ((Math.PI * 2)));

            Point b = baseShape.draw(length, circleModifier, (circleAngle + (Math.PI / 2)), circleTurnModifier);
            double y1 = b.y;
            double x1 = b.x;

            if (fakeAngle <= Math.PI)
            {
                y = x;
                x = 0;
            }
            else
            {
                y = y1;
                x = x1;
            }

            p.x = (int)x;
            p.y = (int)y;
            p = Rotate.rotate(p, Math.PI / 2);

            return p;
        }

    }
}
