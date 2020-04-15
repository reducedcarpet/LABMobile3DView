

using net.firestaff.mcp.baselab.util;
using System;

namespace net.firestaff.mcp.baselab.shapes
{
    public class Oval : AbstractShape
    {

        public Oval()
        {
            name = "Oval";
            Oval.shapeName = name;
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            y = ((length / 2) * circleModifier) * Math.Sin((circleAngle));
            x = ((length / 2) * circleModifier) * Math.Cos((circleAngle)) / 2;

            p.x = x;
            p.y = y;

            return p;
        }

    }
}