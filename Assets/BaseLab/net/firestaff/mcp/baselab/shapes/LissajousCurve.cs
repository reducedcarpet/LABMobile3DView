

using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;
using System;

namespace net.firestaff.mcp.baselab.shapes
{

    public class LissajousCurve : AbstractShape, Shape
    {

        double a = 0.5; // wide
        double b = 1; // tall
        double n = 2; // curve
        double c = 0; // centred

        public LissajousCurve()
        {
            name = "LissajousCurve";
            LissajousCurve.shapeName = name;
            period = Math.PI * 4;
        }

        public LissajousCurve(double pathRotation)
        {
            name = "LissajousCurve";
            period = Math.PI * 4;
            specialPathRotation = pathRotation;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            x = (length * circleModifier) * (a * Math.Sin(n * (circleAngle) + c));
            y = (length * circleModifier) * (b * Math.Sin((circleAngle)));

            p = Rotate.rotate(new Point(x, y), (Math.PI / 2));

            return p;
        }

        public Point drawReverse(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            x = (length * circleModifier) * (a * Math.Sin(n * (circleAngle * -1) + c));
            y = (length * circleModifier) * (b * Math.Sin((circleAngle * -1)));

            p.x = x;
            p.y = y;

            return p;
        }
    }
}

