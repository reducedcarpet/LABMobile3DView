using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;


namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class Epitrochoid : AbstractShape, Shape
    {

        int petal = 4;

        public Epitrochoid()
        {
            name = "Epitrochoid";
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            return drawPetals(length, circleModifier, circleAngle, circleTurnModifier, petal);
        }

        public Point drawPetals(double length, double circleModifier, double circleAngle, double circleTurnModifier, int petals)
        {
            double a = ((length / 4)) * circleModifier; // -30
            double b = a / petals; // number of points. 4 points
            double theta = circleAngle; // where we are around the circle.
            double alpha = ((a + b) / b) * theta;

            x = ((a + b) * Math.Cos(theta)) - ((length / 2) * Math.Cos(alpha));
            y = ((a + b) * Math.Sin(theta)) - ((length / 2) * Math.Sin(alpha));

            // swapping initial sin and cos around makes an epicycloid.
            // swapping both makes for turned hypocycloid.
            p = Rotate.rotate(p, Math.PI / 2);

            p.y = (int)y;
            p.x = (int)x;

            return p;
        }
    }
}
