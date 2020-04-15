using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.weird
{
    public class HLineFig8 : AbstractShape, Shape
    {

        //private double lineCircleModifier = 0;

        public HLineFig8()
        {
            name = "HLineFig8";
            HLineFig8.shapeName = name;
            period = Math.PI * 6;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % (period));

            // stateless draw method
            if (circleAngle <= (Math.PI * 2))
            {   // vert
                x = ((length / 2) * circleModifier) * 1;
                if (realCircleAngle < 0)
                {
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI)));
                }
                else
                    y = ((length / 2) * circleModifier) * Math.Cos((circleAngle - (Math.PI / 2)));
            }
            else if (circleAngle <= Math.PI + (Math.PI * 2))
            {
                y = 0;
                x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
            }
            else if (circleAngle <= (Math.PI * 3))
            {
                y = 0;
                x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
            }
            else if (circleAngle <= (Math.PI * 5))
            {    // vert
                x = ((length / 2) * circleModifier) * -1;
                if (realCircleAngle < 0)
                {
                    y = ((length / 2) * circleModifier) * Math.Cos((circleAngle - (Math.PI + (Math.PI / 2))));
                }
                else
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle));

            }
            else
            {
                y = 0;
                x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
            }

            p.x = (int)x;
            p.y = (int)y;

            return p;
        }
    }
}
