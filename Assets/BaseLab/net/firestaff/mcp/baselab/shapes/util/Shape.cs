using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.util
{
    public interface Shape
    {
        Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier);

        double getPeriod();

        string getName();

        string getUIName();

        double getPathRotation();

        bool equals(Shape shape);

        bool equals(System.Object obj);
    }
}
