using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;


namespace net.firestaff.mcp.baselab.shapes.weird
{
    public class HCurve : AbstractShape, Shape
    {

        //private double lineCircleModifier = 0;

        public HCurve()
        {
            name = "HCurve";
            HCurve.shapeName = name;
            period = Math.PI * 4;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % ((Math.PI * 4)));

            // stateless draw method
            if (circleAngle < (Math.PI))
            {
                if (realCircleAngle < 0)
                {
                    x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
                    y = (((length / 2) * circleModifier) * Math.Sin((circleAngle))) - ((length / 2) * circleModifier);
                }
                else
                {
                    x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
                    y = ((length / 2) * circleModifier) - (((length / 2) * circleModifier) * Math.Sin((circleAngle)));
                }
            }
            else if (circleAngle > (Math.PI) && circleAngle <= (Math.PI * 2))
            {   // vert
                x = ((length / 2) * circleModifier) * -1;
                if (realCircleAngle < 0)
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle + (Math.PI / 2)));
                else
                    y = ((length / 2) * circleModifier) * Math.Cos((circleAngle + (Math.PI)));
            }
            else if (circleAngle > (Math.PI * 2) && circleAngle <= (Math.PI * 3))
            {
                if (realCircleAngle < 0)
                {
                    x = -1 * ((length / 2) * circleModifier) * Math.Cos((circleAngle));
                    y = ((length / 2) * circleModifier) - (((length / 2) * circleModifier) * Math.Sin((circleAngle)));

                }
                else
                {
                    x = -1 * ((length / 2) * circleModifier) * Math.Cos((circleAngle));
                    y = (((length / 2) * circleModifier) * Math.Sin((circleAngle))) - ((length / 2) * circleModifier);
                }
            }
            else
            {
                // vert
                x = ((length / 2) * circleModifier) * 1;
                if (realCircleAngle < 0)
                    y = ((length / 2) * circleModifier) * Math.Cos((circleAngle + (Math.PI)));
                else
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle + (Math.PI / 2)));
            }
            p.x = x;
            p.y = y;

            return p;
        }
    }
}
