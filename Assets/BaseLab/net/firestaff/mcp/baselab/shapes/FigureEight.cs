

using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;
using System;

namespace net.firestaff.mcp.baselab.shapes
{

    public class FigureEight : AbstractShape, Shape
    {


        public FigureEight()
        {
            name = "FigureOfEight";
            FigureEight.shapeName = name;
            period = Math.PI * 4.0;
        }

        public FigureEight(double pathRotation)
        {
            name = "FigureOfEight";
            period = Math.PI * 4.0;
            specialPathRotation = pathRotation;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % (Math.PI * 4.0)); // period is 2 circles.

            if (circleAngle < (Math.PI * 2))
            {
                p = Circle.drawStateless(length, circleModifier, ((realCircleAngle + Math.PI)), circleTurnModifier);
                p.x += (length / 2) * circleModifier;
            }
            else
            {
                p = Circle.drawStateless(length, circleModifier, (realCircleAngle), circleTurnModifier);
                p = reverse(p);
                p.x -= (length / 2) * circleModifier;
            }

            return p;
        }

    }
}
