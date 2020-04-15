using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class QuarterTopLeftComplexShape : AbstractComplexShape, ComplexShape
    {

        public QuarterTopLeftComplexShape()
        {
            name = "QuarterTopLeftComplexShape";
            QuarterTopLeftComplexShape.shapeName = name;
            period = Math.PI;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            circleAngle = Math.Abs(circleAngle % (Math.PI));

            if (circleAngle <= (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, (circleAngle + (Math.PI)), circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if ((circleAngle > (Math.PI / 2)) && (circleAngle <= (Math.PI + (Math.PI / 2))))
            {
                p = drawShape(length, circleModifier, ((Math.PI - circleAngle) + Math.PI), circleTurnModifier);
                y = p.y;
                x = p.x;
            }

            p.x = x;
            p.y = y;

            return p;
        }
    }
}
