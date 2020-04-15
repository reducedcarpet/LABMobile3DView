using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class HypotrochoidEight : Hypotrochoid
    {

        public HypotrochoidEight()
        {
            name = "HypotrochoidEight";
            period = Math.PI * 2;
        }

        public new Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            Point p = drawPetals(length, circleModifier, circleAngle, circleTurnModifier, 8);
            return Rotate.rotate(new Point((int)p.x, (int)p.y), (Math.PI / 4) * -1);
        }
    }
}
