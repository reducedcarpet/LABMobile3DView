using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class FigureEightComplexShape : AbstractComplexShape, ComplexShape
    {


        public FigureEightComplexShape()
        {
            name = "FigureOfEightComplexShape";
            FigureEightComplexShape.shapeName = name;
            period = Math.PI * 4.0;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % (Math.PI * 4.0)); // period is 2 circles.

            if (circleAngle < (Math.PI * 2))
            {
                p = drawShape(length, circleModifier, ((realCircleAngle + Math.PI)), circleTurnModifier);
                p.x += (length / 2) * circleModifier;
            }
            else
            {
                p = drawShape(length, circleModifier, (realCircleAngle + Math.PI), circleTurnModifier);
                p = reverse(p);
                p = Rotate.rotate(p, Math.PI);
                p.x -= (length / 2) * circleModifier;
            }

            return p;
        }

    }
}
