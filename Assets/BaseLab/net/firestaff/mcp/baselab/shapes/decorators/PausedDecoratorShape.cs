using System;

using net.firestaff.mcp.baselab.util;


namespace net.firestaff.mcp.baselab.shapes.decorators
{
    public class PausedDecoratorShape : AbstractDecoratorShape
    {

        double seperation = 0;
        double duration = 0;

        public PausedDecoratorShape()
        {
            name = "PausedIncomplete";
            period = Math.PI * 4;
        }

        public PausedDecoratorShape(double sep, double dur, string nam)
        {
            name = nam;
            period = Math.PI * 4;
            seperation = sep;
            duration = dur;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {
            return drawPaused(length, circleModifier, realCircleAngle, circleTurnModifier, duration, seperation);
        }

        public Point drawPaused(double length, double circleModifier, double realCircleAngle, double circleTurnModifier, double pause, double mPeriod)
        {

            period = baseShape.getPeriod();
            double separation = period / mPeriod;
            //if (mPeriod == 0.75) separation = period * 1.5;

            double pausedPeriod = separation + pause;

            double periodMod = mPeriod;
            if (mPeriod < 1) periodMod = 1;


            double circleAngle = Math.Abs(realCircleAngle % (pausedPeriod * periodMod));


            double count = mPeriod;
            if (count < 1) count = 1;

            double pausedCircleAngle = realCircleAngle % (pausedPeriod * periodMod);

            for (int i = 0; i < count; i++)
            {

                if (circleAngle > (pause * i) + (separation * i) && circleAngle <= pause + (pause * i) + (separation * i))
                {   // pause
                    //System.out.println("PAUSE: " + pause + " SEPERATION: " + separation + " i " + i);
                    p = drawShape(length, circleModifier, (separation * i), circleTurnModifier);
                    y = p.y;
                    x = p.x;
                }
                else if (circleAngle > pause + (pause * i) + (separation * i) && circleAngle <= pause + (pause * i) + separation + (separation * i))
                {   // move
                    //System.out.println("" + i + " CA: " + circleAngle + " rCL: " + realCircleAngle + " mod: " + ((pause * i) + pause));
                    p = drawShape(length, circleModifier, pausedCircleAngle - ((pause * i) + pause), circleTurnModifier);
                    y = p.y;
                    x = p.x;
                }
            }

            p.x = (int)x;
            p.y = (int)y;

            return p;
        }
    }
}
