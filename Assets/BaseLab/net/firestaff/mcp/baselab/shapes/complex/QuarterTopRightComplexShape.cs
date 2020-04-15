using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class QuarterTopRightComplexShape : AbstractComplexShape, ComplexShape
    {

        public QuarterTopRightComplexShape()
        {
            name = "QuarterTopRightComplexShape";
            QuarterTopRightComplexShape.shapeName = name;
            period = Math.PI;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            circleAngle = Math.Abs(circleAngle % (Math.PI));

            if (circleAngle <= (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, (circleAngle - (Math.PI / 2)), circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if ((circleAngle > (Math.PI / 2)) && (circleAngle <= (Math.PI + (Math.PI / 2))))
            {
                p = drawShape(length, circleModifier, ((Math.PI - circleAngle) - (Math.PI / 2)), circleTurnModifier);
                y = p.y;
                x = p.x;
            }

            p.x = (int)x;
            p.y = (int)y;
            //p = Rotate.rotate(p, Math.PI/2);

            return p;
        }
    }
}
