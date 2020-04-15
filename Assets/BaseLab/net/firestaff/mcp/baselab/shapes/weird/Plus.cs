using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.weird
{
    public class Plus : AbstractShape, Shape
    {

        //private double lineCircleModifier = 0;

        public Plus()
        {
            name = "PlusCorner";
            Plus.shapeName = name;
            period = Math.PI * 4;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % ((Math.PI * 4)));

            // corner first
            if (circleAngle < (Math.PI / 2))
            {
                if (realCircleAngle < 0)
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI / 2)));
                }
                else
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI / 2)));
                    //p = reverse(new Point((int)x,(int)y)); x = p.x; y = p.y;
                }
            }
            else if (circleAngle < (Math.PI))
            {   // vert
                if (realCircleAngle < 0)
                {
                    x = ((length / 2) * circleModifier) * Math.Sin((circleAngle + (Math.PI / 2)));
                    y = 0;
                }
                else
                {
                    x = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI / 2)));
                    y = 0;
                    //p = reverse(new Point((int)x,(int)y)); x = p.x; y = p.y;
                }
            }
            else if (circleAngle < (Math.PI + (Math.PI / 2)))
            {
                if (realCircleAngle < 0)
                {
                    x = -1 * ((length / 2) * circleModifier) * Math.Cos((circleAngle + (Math.PI)));
                    y = 0;
                }
                else
                {
                    x = -1 * ((length / 2) * circleModifier) * Math.Cos((circleAngle));
                    y = 0;
                }
            }
            else if (circleAngle < (Math.PI * 2))
            {
                if (realCircleAngle < 0)
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
                }
                else
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
                }
            }
            else if (circleAngle < (Math.PI * 2) + (Math.PI / 2))
            {
                if (realCircleAngle < 0)
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle + Math.PI / 2));
                }
                else
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle + Math.PI / 2));
                }
            }
            else if (circleAngle < (Math.PI * 3))
            {
                if (realCircleAngle < 0)
                {
                    x = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI / 2)));
                    y = 0;
                }
                else
                {
                    x = ((length / 2) * circleModifier) * Math.Sin((circleAngle + (Math.PI / 2)));
                    y = 0;
                }
            }
            else if (circleAngle < (Math.PI * 3) + (Math.PI / 2))
            {
                if (realCircleAngle < 0)
                {
                    x = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI / 2)));
                    y = 0;
                }
                else
                {
                    x = ((length / 2) * circleModifier) * Math.Sin((circleAngle + (Math.PI / 2)));
                    y = 0;
                }
            }
            else if (circleAngle < (Math.PI * 4))
            {
                if (realCircleAngle < 0)
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI / 2)));
                }
                else
                {
                    x = 0;
                    y = ((length / 2) * circleModifier) * Math.Sin((circleAngle - (Math.PI / 2)));
                }
            }
            p.x = (int)x;
            p.y = (int)y;

            return p;
        }
    }
}
