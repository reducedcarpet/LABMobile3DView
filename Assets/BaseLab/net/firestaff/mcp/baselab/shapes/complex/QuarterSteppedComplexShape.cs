using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.complex
{
    public class QuarterSteppedComplexShape : AbstractComplexShape, ComplexShape
    {

        public QuarterSteppedComplexShape()
        {
            name = "QuarterSteppedComplexShape";
            QuarterSteppedComplexShape.shapeName = name;
            period = baseShape.getPeriod() * 3;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double cTM)
        {

            double quarterPeriod = baseShape.getPeriod() / 4;
            double halfPeriod = baseShape.getPeriod() / 2;

            double circleAngle = Math.Abs(realCircleAngle % ((Math.PI * 6)));
            double fakeAngle = Math.Abs(realCircleAngle % ((Math.PI * 6))) % Math.PI;
            realCircleAngle = realCircleAngle % (Math.PI);

            //if(circleAngle < 0) { return drawReverse(length, circleModifier, realCircleAngle, circleTurnModifier);
            //}

            // 0 -> 1.5
            if (circleAngle <= (Math.PI + (Math.PI / 2)))
            {
                if (fakeAngle <= (Math.PI / 2))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle - quarterPeriod), cTM);
                } // 1/2 forwards
                else if ((fakeAngle > (Math.PI / 2)) && (fakeAngle <= (Math.PI + (Math.PI / 2))))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle - quarterPeriod), cTM);
                    p = reverse(p);
                }
            }
            // 1.5 -> 3
            else if (circleAngle <= 2.0 * (Math.PI + (Math.PI / 2)))
            {
                if (fakeAngle <= (Math.PI / 2))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle - (quarterPeriod)), cTM);
                    p = reverse(p);
                }
                // if we're above .5 but under 1.5
                else if ((fakeAngle > (Math.PI / 2)) && (fakeAngle <= (Math.PI + (Math.PI / 2))))
                {
                    p = drawShape(length, circleModifier, ((realCircleAngle) - (quarterPeriod)), cTM);
                }
            }
            // 3 -> 4.5
            else if (circleAngle <= 3.0 * (Math.PI + (Math.PI / 2)))
            {
                if (fakeAngle <= (Math.PI / 2))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle + (Math.PI / 2)), cTM);
                }
                else if ((fakeAngle > (Math.PI / 2)) && (fakeAngle <= (Math.PI + (Math.PI / 2))))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle + (Math.PI / 2)), cTM);
                    p = reverse(p);
                }
            }
            // 4.5 -> 6
            else
            {
                if (fakeAngle <= (Math.PI / 2))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle + quarterPeriod), cTM);
                    p = reverse(p);
                }
                else if ((fakeAngle > (Math.PI / 2)) && (fakeAngle <= (Math.PI + (Math.PI / 2))))
                {
                    p = drawShape(length, circleModifier, (realCircleAngle) + quarterPeriod, cTM);
                }
            }

            // p.x = (int)x;
            // p.y = (int)y;

            return p;
        }

        /*
        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier) {

             double realAngle = circleAngle % ((Math.PI * 6));
            circleAngle = Math.Abs(realAngle);
            //double fakeAngle = circleAngle % (Math.PI * 2);


            if(circleAngle <= (Math.PI)) {
                p = baseShape.draw(length, circleModifier, (Math.PI / 2), cTM);
            } // .5
            else if(circleAngle <= Math.PI + (Math.PI / 2)) {
                double fakeAngle = realAngle - (Math.PI /2 );
                p = baseShape.draw(length, circleModifier, fakeAngle, cTM);
            } // 1
            else if (circleAngle <= (Math.PI * 2 + (Math.PI / 2))) {
                p = baseShape.draw(length, circleModifier, (Math.PI), cTM);
            } // .5
            else if(circleAngle <= (Math.PI * 3)) {
                double fakeAngle = realAngle - (Math.PI + (Math.PI / 2));
                p = baseShape.draw(length, circleModifier, fakeAngle, cTM);
            } // 1
            else if(circleAngle <= ((Math.PI * 4) )) {
                p = baseShape.draw(length, circleModifier, ((Math.PI) + (Math.PI / 2)), cTM);
            } // .5
            else if(circleAngle <= (Math.PI * 4) + (Math.PI / 2)) {
                double fakeAngle = realAngle - ((Math.PI * 2) + (Math.PI / 2));
                p = baseShape.draw(length, circleModifier, fakeAngle, cTM);
            } // 1
            else if(circleAngle <= ((Math.PI * 5) + (Math.PI / 2))) {
                p = baseShape.draw(length, circleModifier, (Math.PI * 2), cTM);
            } // .5
            else {
                double fakeAngle = realAngle - ((Math.PI * 3) + (Math.PI / 2));
                p = baseShape.draw(length, circleModifier, fakeAngle, cTM);
            }

        }
        /**/
    }
}
