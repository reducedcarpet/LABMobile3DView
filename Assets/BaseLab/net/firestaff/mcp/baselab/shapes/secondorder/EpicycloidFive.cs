using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.secondorder
{
    public class EpicycloidFive : Epicycloid {

        public EpicycloidFive() {
            name = "EpicycloidFive";
            period = Math.PI * 2;
        }

        public new Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier) {
            Point p = drawPetals(length, circleModifier, circleAngle + Math.PI, circleTurnModifier, 5);
            return Rotate.rotate(new Point((int)p.x, (int)p.y), Math.PI);
        }
    }
}
