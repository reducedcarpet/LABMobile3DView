using System;

namespace net.firestaff.mcp.baselab.speeds.speed {

    public class SpeedHelper {

        public static double updateSimpleSymmetricOnOffAngle(double angle, double increment, double speed, int direction, double period) {
            double still = (increment * speed * direction) * -1.0;
            double circleAngle = Math.Abs(angle % (period * 2.0));

            if (circleAngle >= (period)) {
                return still;
            }
            else return 0;
        }

        public static double updateSymmetricPolySpeedAngle(double upperSpeed, double lowerSpeed, double angle, double propAngle, double increment, double speed, int direction, double period, double mod) {

            angle += mod;

            double still = (increment * (upperSpeed - lowerSpeed) * direction);
            double upper = 0;
            double circleAngle = Math.Abs(angle % (period * 4.0));

            if (circleAngle >= period && circleAngle < (period * 2)) {

                /*
                if(Math.Abs(angle % (period * 8.0)) >= (period * 4.0))
                    still = (( still) - (period * 3)) * -1;
                else still = (( still) - period) * -1;

                if(propAngle < 0) {
                    if(Math.Abs(angle % (period * 8.0)) >= (period * 4.0))
                        still = (( still) - (period * 3)) * 1;
                    else still = (( still)  - period) * 1;
                } /**/

                return still;
            }
            else if (circleAngle >= (period * 2) && circleAngle < (period * 3)) {
                return upper;
            }
            else if (circleAngle >= (period * 3) && circleAngle < (period * 4)) {
                /*
                if(Math.Abs(angle % (period * 8.0)) >= (period * 4.0)) still = (((propAngle) + still)) * -1;
                else still = (((propAngle - (period * 2)) + still)) * -1;

                if(propAngle < 0) {
                    if(Math.Abs(angle % (period * 8.0)) >= (period * 4.0))
                        still = (((propAngle) + still)); //((propAngle  + still)) * -1;
                    else still = (((propAngle - (period * 2)) + still)); //((propAngle + still)) * -1;
                } /**/

                return still;
            }

            return upper;

        }

        public static double updateSymmetricOnOffAngle(double angle, double propAngle, double increment, double speed, int direction, double period, double mod) {

            angle += mod;
            propAngle += mod;

            double still = (increment * speed * direction);
            double circleAngle = Math.Abs(angle % (period * 4.0));

            //System.out.println("BEFORE: mod " + circleAngle + " :angle: " + angle + " :prop: " + propAngle);

            // 0 -> period return 0 = moving
            if (circleAngle >= period && circleAngle < (period * 2)) {
                // System.out.println(circleAngle + " :angle: " + angle + " :prop: " + propAngle);
                // we either want to get to propAngle = 0, or period. flat or vertical. (inside or outside)
                // messes up only on the 2nd round
                // when propAngle > period * 5
                if (Math.Abs(angle % (period * 8.0)) >= (period * 4.0)) still = ((propAngle + still) - (period * 3)) * -1;
                else still = ((propAngle + still) - period) * -1;


                if (propAngle < 0) {
                    if (Math.Abs(angle % (period * 8.0)) >= (period * 4.0))
                        still = ((propAngle + still) - (period * 3)) * 1;
                    else still = ((propAngle + still) - period) * 1;
                }

                return still;
            }
            else if (circleAngle >= (period * 2) && circleAngle < (period * 3)) {
                //System.out.println("MOVING >2");
                return 0; // moving
            }
            else if (circleAngle >= (period * 3) && circleAngle < (period * 4)) {
                // System.out.println(circleAngle + " :angle: " + angle + " :prop: " + propAngle);
                // we either want to get to propAngle = 0, or period. flat or vertical. (inside or outside)
                // something about if we are over the limit then set it to the otherway around somehow.
                // this one is the wrong way round
                // it's the different of Math.pi / period * 2

                if (Math.Abs(angle % (period * 8.0)) >= (period * 4.0)) still = (((propAngle) + still)) * -1;
                else still = (((propAngle - (period * 2)) + still)) * -1;

                if (propAngle < 0) {
                    if (Math.Abs(angle % (period * 8.0)) >= (period * 4.0))
                        still = (((propAngle) + still)); //((propAngle  + still)) * -1;
                    else still = (((propAngle - (period * 2)) + still)); //((propAngle + still)) * -1;
                }
                //System.out.println("STILL >3 " + angle);

                return still;
            }
            //System.out.println("MOVING >0");
            return 0;
        }



        public static double updateAsymmetricOnOffAngle(double angle, double propAngle, double increment, double speed, int direction, double periodOn, double periodOff, double mod) {

            angle += mod;
            propAngle += mod;

            double still = (increment * speed * direction);
            double circleAngle = Math.Abs(angle % ((periodOn + periodOff) * 2.0));
            double fullPeriod = (periodOn + periodOff) * 2.0;


            // 0 -> period return 0 = moving
            if (circleAngle >= periodOn && circleAngle < (periodOn + periodOff)) {

                if (Math.Abs(angle % (fullPeriod * 2.0)) >= fullPeriod)
                    still = ((propAngle + still) - ((periodOn))) * -1;
                else still = ((propAngle + still) - (periodOn)) * -1;

                return still;
            }
            else if (circleAngle >= (periodOn + periodOff) && circleAngle < ((periodOn + periodOff) + periodOn)) {
                return 0; // moving
            }
            else if (circleAngle >= ((periodOn + periodOff) + periodOn) && circleAngle < ((periodOn + periodOff) * 2)) {

                if (Math.Abs(angle % (fullPeriod * 2.0)) >= fullPeriod)
                    still = (((propAngle - periodOff) + still)) * -1;
                else still = (((propAngle - (periodOff)) + still)) * -1;

                return still;
            }

            return 0;
        }



        public static Speed getSpeed(string name, double upperSpeed, double lowerSpeed) {
            Speed togo = new ConstantSpeed();

            if (name == null) return togo;
            if (name == "" || name.Equals("None")) return togo;

            string shape = name;
            foreach (Speed s in SpeedConstants.shapes) {
                if (s.getName().Equals(shape)) {
                    togo = s.copy();
                    togo.setLowerSpeed(lowerSpeed);
                    togo.setUpperSpeed(upperSpeed);
                    return togo;
                }
            }
            return togo;
        }
    }
}
