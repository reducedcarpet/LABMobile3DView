using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class HypotrochoidFive : Hypotrochoid
    {

        public HypotrochoidFive()
        {
            name = "HypotrochoidFive";
            period = Math.PI * 2;
        }

        public new Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            return drawPetals(length, circleModifier, circleAngle, circleTurnModifier, 5);
        }
    }
}
