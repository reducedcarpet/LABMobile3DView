using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;


namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class HypocycloidFake : AbstractShape, Shape
    {

        public HypocycloidFake()
        {
            name = "HypocycloidFake";
            period = Math.PI * 2;
        }

        public Point drawStateless(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            double a = ((length / 2)) * circleModifier; // -30
            double b = a / 4; // number of points. 4 points
            double theta = circleAngle + (Math.PI / 4); // where we are around the circle.
            double alpha = ((a - b) / b) * theta;

            x = ((a - b) * Math.Cos(theta)) - (b * Math.Cos(alpha));
            y = ((a - b) * Math.Sin(theta)) + (b * Math.Sin(alpha));

            Point pp = new Point(x, (int)y);

            // swapping initial sin and cos around makes an epicycloid.
            // swapping both makes for turned hypocycloid.
            p = Rotate.rotate(pp, (Math.PI / 4) * -1);

            //p.y = (int)y;
            //p.x = (int)x;

            return p;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {
            realCircleAngle = realCircleAngle * -1;
            double circleAngle = Math.Abs(realCircleAngle % (Math.PI * 2.0)); // period is 1 circles.


            if (circleAngle < ((Math.PI / 2)))
            {
                p = Circle.drawStateless(length, circleModifier, (realCircleAngle - (Math.PI / 2)), circleTurnModifier);
                y = p.y;
                x = p.x;
                if (realCircleAngle >= 0)
                {
                    y += (length / 2) * circleModifier;
                    x -= (length / 2) * circleModifier;
                }
                else
                {
                    y += (length / 2) * circleModifier;
                    x += (length / 2) * circleModifier;
                }
            }
            else if (circleAngle >= ((Math.PI / 2)) && circleAngle < (Math.PI))
            {
                p = Circle.drawStateless(length, circleModifier, (realCircleAngle + (Math.PI / 2)), circleTurnModifier);
                y = p.y;
                x = p.x;
                if (realCircleAngle >= 0)
                {
                    y += (length / 2) * circleModifier;
                    x += (length / 2) * circleModifier;
                }
                else
                {
                    y += (length / 2) * circleModifier;
                    x -= (length / 2) * circleModifier;
                }
            }
            else if (circleAngle >= (Math.PI) && circleAngle < ((Math.PI) + (Math.PI / 2)))
            {
                p = Circle.drawStateless(length, circleModifier, (realCircleAngle - (Math.PI / 2)), circleTurnModifier);

                y = p.y;
                x = p.x;
                if (realCircleAngle >= 0)
                {
                    y -= (length / 2) * circleModifier;
                    x += (length / 2) * circleModifier;
                }
                else
                {
                    y -= (length / 2) * circleModifier;
                    x -= (length / 2) * circleModifier;
                }
            }
            else if (circleAngle >= ((Math.PI) + (Math.PI / 2)) && circleAngle <= (Math.PI * 2))
            {
                p = Circle.drawStateless(length, circleModifier, (realCircleAngle + (Math.PI / 2)), circleTurnModifier);

                y = p.y;
                x = p.x;
                if (realCircleAngle >= 0)
                {
                    y -= (length / 2) * circleModifier;
                    x -= (length / 2) * circleModifier;
                }
                else
                {
                    y -= (length / 2) * circleModifier;
                    x += (length / 2) * circleModifier;
                }
            }
            //if(realCircleAngle < 0) p = reverse(p);
            /*
            else {
                if( circleAngle < ((Math.PI / 2))) {
                    p = Circle.drawStateless(length, circleModifier, (realCircleAngle - (Math.PI / 2)), circleTurnModifier);
                    y = p.y;
                    x = p.x;
                    y += (length / 2) * circleModifier;
                    x += (length / 2) * circleModifier;
                }
                else if( circleAngle >= ((Math.PI / 2)) &&  circleAngle < (Math.PI)) {
                    p = Circle.drawStateless(length, circleModifier, (realCircleAngle + (Math.PI / 2)), circleTurnModifier);
                    y = p.y;
                    x = p.x;
                    y += (length / 2) * circleModifier;
                    x -= (length / 2) * circleModifier;
                }
                else if( circleAngle >= (Math.PI) &&  circleAngle < ((Math.PI) + (Math.PI / 2))) {
                    p = Circle.drawStateless(length, circleModifier, (realCircleAngle - (Math.PI / 2)), circleTurnModifier);
                    y = p.y;
                    x = p.x;
                    y -= (length / 2) * circleModifier;
                    x -= (length / 2) * circleModifier;
                }
                else if( circleAngle >= ((Math.PI) + (Math.PI / 2)) &&  circleAngle <= (Math.PI * 2)) {
                    p = Circle.drawStateless(length, circleModifier, (realCircleAngle + (Math.PI / 2)), circleTurnModifier);
                    y = p.y;
                    x = p.x;
                    y -= (length / 2) * circleModifier;
                    x += (length / 2) * circleModifier;
                }
               //p = reverse(p);
            }
            /**/

            p.x = (int)x;
            p.y = (int)y;

            return p;

        }
    }
}
