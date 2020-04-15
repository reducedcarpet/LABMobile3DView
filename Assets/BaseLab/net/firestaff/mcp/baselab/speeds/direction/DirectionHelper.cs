using System;

namespace net.firestaff.mcp.baselab.speeds.direction {

    public class DirectionHelper {

        public static int updateAsymmetricOnOffAngle(double angle, int direction, double period, double mod) {

            //double still = (increment * speed * direction);
            double circleAngle = Math.Abs((angle + mod) % (period * 2.0));

            //System.out.println("Direction: " + direction + " angle " + circleAngle + " period " + period);
            // 0 -> period return 0 = moving
            if (circleAngle <= period) {
                //System.out.println("Direction NO CHANGE: " + direction);
                return direction;
            }
            else {
                //System.out.println("Direction CHANGE: " + direction * -1);
                return direction * -1;
            }
        }

        public static Direction getDirectionControl(string name) {
            Direction togo = new NoChange();

            if (name == null) return togo;
            if (name == "" || name.Equals("None")) return togo;

            string shape = name;
            foreach (Direction s in DirectionConstants.shapes) {
                if (s.getName().Equals(shape)) {
                    togo = s;
                    break;
                }
            }
            return togo;
        }
    }
}
