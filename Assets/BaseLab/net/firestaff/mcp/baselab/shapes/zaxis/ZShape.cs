namespace net.firestaff.mcp.baselab.shapes.zaxis
{

    public interface ZShape
    {

        string getName();

        double draw(double realPathAngle, double zMod);
    }
}
