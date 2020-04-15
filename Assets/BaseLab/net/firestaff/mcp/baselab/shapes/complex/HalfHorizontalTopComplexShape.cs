using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class HalfHorizontalTopComplexShape : AbstractComplexShape, ComplexShape
    {

        //static {
        //   shapeName = "HalfHorizontalTopComplexShape";
        //}

        public HalfHorizontalTopComplexShape()
        {
            name = HalfHorizontalTopComplexShape.shapeName;
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(circAngle % (Math.PI * 2.0));

            if (circleAngle >= Math.PI)
            {
                p = drawShape(length, circleModifier, circleAngle, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else
            {
                p = drawShape(length, circleModifier, (circleAngle * -1), circleTurnModifier);
                y = p.y;
                x = p.x;
            }

            p.x = x;
            p.y = y;

            return p;
        }
    }
}