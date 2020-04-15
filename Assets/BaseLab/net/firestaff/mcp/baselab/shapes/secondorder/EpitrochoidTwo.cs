using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class EpitrochoidTwo : Epitrochoid
    {

        public EpitrochoidTwo()
        {
            name = "EpitrochoidTwo";
            period = Math.PI * 2;
        }

        public new Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            return drawPetals(length, circleModifier, circleAngle, circleTurnModifier, 2);
        }
    }
}
