using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class FigureEightBrokenComplexShape : AbstractComplexShape, ComplexShape
    {


        public FigureEightBrokenComplexShape()
        {
            name = "FigureOfEightBrokenComplexShape";
            FigureEightBrokenComplexShape.shapeName = name;
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
                p = Rotate.rotate(p, Math.PI);
                p.x -= (length / 2) * circleModifier;
            }

            return p;
        }

    }
}
