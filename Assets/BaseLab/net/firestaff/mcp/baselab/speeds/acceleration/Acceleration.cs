namespace net.firestaff.mcp.baselab.speeds.acceleration {

public interface Acceleration {

    double updateAngle(double angle, double increment, double speed, int direction);

    void reset(int propDirection);
}
}
