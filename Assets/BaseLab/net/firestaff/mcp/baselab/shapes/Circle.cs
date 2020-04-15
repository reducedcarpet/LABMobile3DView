
using net.firestaff.mcp.baselab.util;
using System; 

namespace net.firestaff.mcp.baselab.shapes
{
    public class Circle : AbstractShape
    {

        public Circle()
        {
            name = "Circle";
            Circle.shapeName = name;
            period = Math.PI * 2;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            y = ((length / 2) * circleModifier) * Math.Sin((circleAngle));
            x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));

            p.x = x;
            p.y = y;

            return p;
        }

        public static Point drawStateless(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            double y = ((length / 2) * circleModifier) * Math.Sin((circleAngle));
            double x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));

            Point p = new Point();
            p.x = x;
            p.y = y;

            return p;
        }

        public static Point draw3D(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {
            double x = ((length / 2) * circleModifier) * Math.Cos(circleAngle) * Math.Sin(circleAngle );
            double y = ((length / 2) * circleModifier) * Math.Sin(circleAngle) * Math.Sin(circleAngle );
            double z = ((length / 2) * circleModifier) * Math.Cos(circleAngle);

            Point p = new Point();
            p.x = x;
            p.y = y;
            p.z = z;

            return p;
        }
    }
}
