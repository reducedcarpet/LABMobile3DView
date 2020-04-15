using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class SquishXComplexShape : AbstractComplexShape, ComplexShape
    {

        public SquishXComplexShape()
        {
            name = "SquishXComplexShape";
            SquishXComplexShape.shapeName = name;
            period = baseShape.getPeriod();
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            p = baseShape.draw(length, circleModifier, circleAngle, circleTurnModifier);
            p.x = 0;

            return p;
        }
    }
}
