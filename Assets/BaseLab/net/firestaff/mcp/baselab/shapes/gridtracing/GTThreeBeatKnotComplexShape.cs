using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.gridtracing
{
    public class GTThreeBeatKnotComplexShape : AbstractComplexShape, ComplexShape
    {

        public GTThreeBeatKnotComplexShape()
        {
            name = "GTThreeBeatKnotComplexShape";
            GTThreeBeatKnotComplexShape.shapeName = name;
            period = Math.PI * 6.0;
        }


        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {
            double circleAngle = Math.Abs(realCircleAngle % (period)); // period is 2 circles.

            if (realCircleAngle >= 0)
            {
                // 4 steps of a normal circle
                if (circleAngle < (Math.PI * 2))
                {

                    p = drawShape(length, circleModifier, ((realCircleAngle + Math.PI)), circleTurnModifier);
                    p.x += (length / 2) * circleModifier;
                    p.y += (length / 2) * circleModifier;

                } // 1 steps of another circle
                else if (circleAngle < (Math.PI * 2) + (Math.PI / 2))
                {

                    p = drawShape(length, circleModifier, (realCircleAngle), circleTurnModifier);
                    p = reverse(p);
                    p.x -= (length / 2) * circleModifier;
                    p.y += (length / 2) * circleModifier;
                    //p.y += (length / 2) * circleModifier;

                } // 4 again
                else if (circleAngle < (Math.PI * 4) + (Math.PI / 2))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle), circleTurnModifier);
                    p.x -= (length / 2) * circleModifier;
                    p.y -= (length / 2) * circleModifier;
                    //p = reverse(p);
                } // 3
                else if (circleAngle < (Math.PI * 6))
                {

                    p = drawShape(length, circleModifier, (realCircleAngle), circleTurnModifier);
                    p = reverse(p);
                    p.x -= (length / 2) * circleModifier;
                    p.y += (length / 2) * circleModifier;

                }
            }

            if (realCircleAngle < 0)
            {
                // 4 steps of a normal circle
                if (circleAngle < (Math.PI * 2))
                {
                    p = drawShape(length, circleModifier, ((realCircleAngle + Math.PI)), circleTurnModifier);
                    p.x += (length / 2) * circleModifier;
                    p.y += (length / 2) * circleModifier;

                } // 3 steps of another circle
                else if (circleAngle < (Math.PI * 3) + (Math.PI / 2))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle), circleTurnModifier);
                    p = reverse(p);
                    p.x -= (length / 2) * circleModifier;
                    p.y += (length / 2) * circleModifier;

                } // 4 again
                else if (circleAngle < (Math.PI * 5) + (Math.PI / 2))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle), circleTurnModifier);
                    p.x -= (length / 2) * circleModifier;
                    p.y -= (length / 2) * circleModifier;

                } // 1
                else if (circleAngle < (Math.PI * 6))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle), circleTurnModifier);
                    p = reverse(p);
                    p.x -= (length / 2) * circleModifier;
                    p.y += (length / 2) * circleModifier;

                }
            }

            return p;

        }
    }
}
