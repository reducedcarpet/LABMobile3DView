using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class HalfVerticalRightComplexShape : AbstractComplexShape, ComplexShape
    {


        //   shapeName = "HalfVerticalRightComplexShape";


        public HalfVerticalRightComplexShape()
        {
            name = "HalfVerticalRightComplexShape";
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circAngle, double circleTurnModifier)
        {
            double circleAngle = Math.Abs(circAngle % (Math.PI * 2.0));

            // first quarter
            if (circleAngle <= (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, circleAngle, circleTurnModifier);
                y = p.y;
                x = p.x;
            } // middle half
            else if ((circleAngle > (Math.PI / 2)) && (circleAngle <= (Math.PI + (Math.PI / 2))))
            {
                p = drawShape(length, circleModifier, ((Math.PI + circleAngle) * -1), circleTurnModifier);
                y = p.y;
                x = p.x;
            } // 2nd quarter
            else if (circleAngle >= (Math.PI + (Math.PI / 2)))
            {
                p = drawShape(length, circleModifier, circleAngle, circleTurnModifier);
                y = p.y;
                x = p.x;
            }

            p.x = x;
            p.y = y;

            return p;
        }
    }
}
