using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class FullComplexShape : AbstractComplexShape, ComplexShape
    {

        public FullComplexShape()
        {
            name = "FullComplexShape";
            FullComplexShape.shapeName = name;
            period = Math.PI * 4;
        }

        override public Point draw(double length, double circleModifier, double circAngle, double circleTurnModifier)
        {
            double circleAngle = Math.Abs(circAngle % (Math.PI * 4.0));

            if (circleAngle <= (Math.PI * 2.0))
            {
                p = baseShape.draw(length, circleModifier, circleAngle, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else
            {
                p = baseShape.draw(length, circleModifier, (circleAngle), circleTurnModifier);
                p = reverse(p);
                y = p.y;
                x = p.x;
            }

            p.x = x;
            p.y = y;

            return p;
        }
    }
}
