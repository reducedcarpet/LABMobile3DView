using System;

namespace net.firestaff.mcp.baselab.speeds.acceleration {

    public class PendulumAcceleration : Acceleration {

        double gravity = ((Math.PI / 125) / Math.PI) / 4;  //0.008
        double aAcceleration = 0;
        double aVelocity = 0; // 0.078
        double terminalVel = ((Math.PI / 125) * 8);

        int dir;

        public PendulumAcceleration()
        { }

        public double updateAngle(double angle, double increment, double speed, int direction) {
            if (dir != direction) reset();
            dir = direction;
            aAcceleration = gravity * Math.Cos(angle);
            aVelocity += aAcceleration;
            if (aVelocity > terminalVel) {
                //System.out.println("Hit terminal velocity");
                aVelocity = terminalVel;
            }

            return aVelocity;
            // ((increment  * speed) + aVelocity) * direction;
        }

        public void reset(int _dir) {
            if (dir != _dir) {
                reset();
            }
        }

        private void reset() {
            aAcceleration = 0;
            aVelocity = 0;
        }
    }
}
