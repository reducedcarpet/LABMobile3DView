using System;

namespace net.firestaff.mcp.baselab.speeds.acceleration { 

public class GravityAcceleration : Acceleration {

    double gravity = ((Math.PI / 125) / Math.PI) / 2;  //0.008
    double aAcceleration = 0 ;
    double aVelocity = (Math.PI / 125) * 3 ; // 0.078
    //double damping = 1;//0.995;
    double terminalVel = ((Math.PI / 125) * 8);

    int dir;

    public GravityAcceleration()
    { }

    
    public double updateAngle(double angle, double increment, double speed, int direction) {
        if(dir != direction) reset();
        dir = direction;
        aAcceleration = gravity * Math.Cos(angle);
        aVelocity += aAcceleration;
        if(aVelocity > terminalVel) {
            aVelocity = terminalVel;
        }

        return aVelocity;
    }

    public void reset(int _dir) {
        if(dir != _dir) {
            reset();
        }
    }

    private void reset() {
        aAcceleration = 0;
        aVelocity = (Math.PI / 125) * 3 ;
    }
}
}
