using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class HypotrochoidSix : Hypotrochoid
    {

        public HypotrochoidSix()
        {
            name = "HypotrochoidSix";
            period = Math.PI * 2;
        }

        public new Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            Point p = drawPetals(length, circleModifier, circleAngle, circleTurnModifier, 6);
            return Rotate.rotate(new Point(p.x, p.y), (Math.PI / 4) * -1);
        }
    }
}
