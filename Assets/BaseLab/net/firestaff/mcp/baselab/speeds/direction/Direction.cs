namespace net.firestaff.mcp.baselab.speeds.direction
{

    public interface Direction
    {

        int updateAngle(double angle, int direction, double mod);

        string getName();
    }
}
