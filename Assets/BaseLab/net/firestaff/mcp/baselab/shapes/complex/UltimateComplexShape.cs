using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class UltimateComplexShape : AbstractComplexShape, ComplexShape
    {

        public UltimateComplexShape()
        {
            name = "UltimateComplexShape";
            UltimateComplexShape.shapeName = name;
            period = Math.PI * 20;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {

            double circleAngle = Math.Abs(realCircleAngle % period);

            if (circleAngle < (Math.PI / 2)) //1
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            } // 2
            else if (circleAngle < Math.PI)
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } //3 - 4
            else if (circleAngle < (Math.PI * 2))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                x = p.x;
                y = p.y;
            } // 5 - 8
            else if (circleAngle < ((Math.PI * 3) + (Math.PI / 2)))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 8 - 10
            else if (circleAngle < (Math.PI * 4) + (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            } // 11
            else if (circleAngle < ((Math.PI * 5)))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 12
            else if (circleAngle < (Math.PI * 5) + (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                x = p.x;
                y = p.y;
            } // 13
            else if (circleAngle < ((Math.PI * 6)))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 14
            else if (circleAngle < (Math.PI * 6) + (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            }
            // 14 - 20
            else if (circleAngle < ((Math.PI * 9) + (Math.PI / 2)))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 21 -23
            else if (circleAngle < (Math.PI * 10) + (Math.PI / 2))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            } // 22 - 24
            else if (circleAngle < ((Math.PI * 11) + (Math.PI / 2)))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 28 - 31
            else if (circleAngle < (Math.PI * 13))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            }// 32
            else if (circleAngle < ((Math.PI * 13) + (Math.PI / 2)))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 33
            else if (circleAngle < (Math.PI * 14))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                x = p.x;
                y = p.y;
            }//  33 - 39
            else if (circleAngle < ((Math.PI * 17)))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 40 -42
            else if (circleAngle < (Math.PI * 18))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                x = p.x;
                y = p.y;
            } // 42
            else if (circleAngle < ((Math.PI * 18) + (Math.PI / 2)))
            {
                p = drawShape(length, circleModifier, realCircleAngle - (Math.PI), circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            } // 43
            else if (circleAngle < (Math.PI * 19))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                x = p.x;
                y = p.y;
            } // 44 -45
            else if (circleAngle < ((Math.PI * 20)))
            {
                p = drawShape(length, circleModifier, realCircleAngle, circleTurnModifier);
                p = reverse(p);
                x = p.x;
                y = p.y;
            }

            p.x = (int)x;
            p.y = (int)y;

            return p;
        }

    }
}
