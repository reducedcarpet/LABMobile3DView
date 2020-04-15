using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.decorators
{
    public class FullReverseDecoratorShape : AbstractDecoratorShape
    {

        public FullReverseDecoratorShape()
        {
            name = "FullReverseDecoratorShape";
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % ((Math.PI * 4)));

            if (circleAngle < (Math.PI * 2))
            {   // 0 -> 1 pause
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                y = p.y;
                x = p.x;
            }
            else if (circleAngle >= (Math.PI * 2) && circleAngle < (Math.PI * 4))
            {   // 1 -> 3 move
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                y = p.y;
                x = p.x;
            }

            p.x = (int)x;
            p.y = (int)y;

            return p;
        }

    }
}
