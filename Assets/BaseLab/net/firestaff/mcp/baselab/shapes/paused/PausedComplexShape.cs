using System;

using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.paused
{
    public class PausedComplexShape : PausedHelper
    {

        double seperation = 0;
        double duration = 0;

        public PausedComplexShape()
        {
            name = "PausedIncomplete";
            PausedComplexShape.shapeName = name;
            period = Math.PI * 4;
        }

        public PausedComplexShape(double sep, double dur, string nam)
        {
            name = nam;
            period = Math.PI * 4;
            seperation = sep;
            duration = dur;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {
            return base.drawPaused(length, circleModifier, realCircleAngle, circleTurnModifier, duration, seperation);
        }
    }
}
