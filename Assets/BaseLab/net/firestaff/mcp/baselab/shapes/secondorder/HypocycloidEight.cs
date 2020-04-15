using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class HypocycloidEight : AbstractShape, Shape
    {

        public HypocycloidEight()
        {
            name = "HypocycloidEight";
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            double a = ((length / 2)) * circleModifier; // -30
            double b = a / 8; // number of points. 4 points
            double theta = circleAngle + (Math.PI / 2); // where we are around the circle.
            double alpha = ((a - b) / b) * theta;

            x = ((a - b) * Math.Cos(theta)) - (b * Math.Cos(alpha));
            y = ((a - b) * Math.Sin(theta)) + (b * Math.Sin(alpha));


            p = Rotate.rotate(new Point(x, y), (Math.PI / 2));


            return p;
        }
    }
}