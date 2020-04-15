using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class HalfVerticalLeftComplexShape : AbstractComplexShape, ComplexShape
    {

        // static {
        //    shapeName = "HalfVerticalLeftComplexShape";
        //}

        public HalfVerticalLeftComplexShape()
        {
            name = "HalfVerticalLeftComplexShape";
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circAngle, double circleTurnModifier)
        {
            double circleAngle = Math.Abs(circAngle % (Math.PI * 2.0));

            if (circleAngle <= (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, (circAngle + Math.PI), circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if ((circleAngle > (Math.PI / 2)) && (circleAngle <= (Math.PI + (Math.PI / 2))))
            {
                p = drawShape(length, circleModifier, ((circAngle)), circleTurnModifier);
                p = reverse(p);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle >= (Math.PI + (Math.PI / 2)))
            {
                p = drawShape(length, circleModifier, (circAngle + Math.PI), circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            //else System.out.println("4 " + circleAngle);

            p.x = x;
            p.y = y;

            return p;
        }
    }
}
