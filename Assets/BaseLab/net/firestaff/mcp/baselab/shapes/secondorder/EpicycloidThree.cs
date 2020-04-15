using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class EpicycloidThree : Epicycloid
    {

        public EpicycloidThree()
        {
            name = "EpicycloidThree";
            period = Math.PI * 2;
        }

        public new Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            Point p = drawPetals(length, circleModifier, circleAngle + Math.PI, circleTurnModifier, 3);
            return Rotate.rotate(new Point(p.x, p.y), Math.PI);
        }
    }
}
