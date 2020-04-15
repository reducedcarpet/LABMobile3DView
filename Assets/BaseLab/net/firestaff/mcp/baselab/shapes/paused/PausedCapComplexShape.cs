using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.paused
{
    public class PausedCapComplexShape : AbstractComplexShape
    {

        double mSeperation = 0;
        double duration = 0;

        public PausedCapComplexShape()
        {
            name = "PausedCapIncomplete";
            PausedCapComplexShape.shapeName = name;
            period = Math.PI * 4;
        }

        public PausedCapComplexShape(double sep, double dur, string nam)
        {
            name = nam;
            period = Math.PI * 4;
            mSeperation = sep;
            duration = dur;
        }

        override public Point draw(double length, double circleModifier, double realCircleAngle, double circleTurnModifier)
        {
            period = baseShape.getPeriod();
            double separation = period / mSeperation;
            //if (mPeriod == 0.75) separation = period * 1.5;

            double pausedPeriod = separation + duration;
            double pause = duration;

            //double periodMod = mSeperation;
            //if(mSeperation < 1) periodMod = 1;

            double circleAngle = Math.Abs(realCircleAngle % (pausedPeriod * 2));
            double newCircleAngle = (realCircleAngle % (pausedPeriod * 2));

            double count = 3;


            for (int i = 0; i < count; i++)
            {
                if (realCircleAngle > 0)
                {
                    if (circleAngle > (pause * i) + (separation * i) && circleAngle <= pause + (pause * i) + (separation * i))
                    {   // pause
                        p = drawShape(length, circleModifier, (separation * i), circleTurnModifier);
                        y = p.y;
                        x = p.x;
                    }
                    else if (circleAngle > pause + (pause * i) + (separation * i) && circleAngle <= pause + (pause * i) + separation + (separation * i))
                    {   // move
                        if (!(i % 2 == 0))
                        {
                            p = drawShape(length, circleModifier, newCircleAngle - ((pause * i) + pause + (separation * 2)), circleTurnModifier);
                            p = reverse(p);
                        }
                        else
                            p = drawShape(length, circleModifier, newCircleAngle - ((pause * i) + pause), circleTurnModifier);

                        y = p.y;
                        x = p.x;
                    }
                }
                else
                {
                    if (circleAngle > (pause * i) + (separation * i) && circleAngle <= pause + (pause * i) + (separation * i))
                    {   // pause
                        ////System.out.println("PAUSE: " + pause + " SEPERATION: " + separation + " i " + i);
                        p = drawShape(length, circleModifier, (separation * -i), circleTurnModifier);
                        y = p.y;
                        x = p.x;
                    }
                    else if (circleAngle > pause + (pause * i) + (separation * i) && circleAngle <= pause + (pause * i) + separation + (separation * i))
                    {   // move
                        //System.out.println("" + i + " " + !(i % 2 == 0) + " pp: " + pausedPeriod * 2 + " rCL: " + (circleAngle - ((pause * i) + pause)) + " mod: " + (circleAngle - ((pause * i) + pause + (separation * 2))));

                        if (!(i % 2 == 0))
                        {
                            //System.out.println("Reversing");
                            p = drawShape(length, circleModifier, newCircleAngle + ((pause * i) + pause + (separation * 2)), circleTurnModifier);
                            p = reverse(p);

                        }
                        else
                        {
                            p = drawShape(length, circleModifier, newCircleAngle + ((pause * i) + pause), circleTurnModifier);
                        }


                        y = p.y;
                        x = p.x;
                    }
                }

            }


            p.x = (int)x;
            p.y = (int)y;

            return p;
        }
    }
}
