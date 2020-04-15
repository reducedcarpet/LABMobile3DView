

using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;
using System;

namespace net.firestaff.mcp.baselab.shapes
{

    public class Dot : AbstractShape, Shape
    {

        public Dot()
        {
            name = "Point";
            Dot.shapeName = name;
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            x = 0;
            y = 0;

            p.x = x;
            p.y = y;

            return p;
        }
    }
}
