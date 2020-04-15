using System;

namespace net.firestaff.mcp.baselab.util
{
    public class Rotate
    {

        static double x;
        static double y;
        static double z;

        public static Point rotate(Point p, double angle)
        {
            x = p.x;
            y = p.y;
            //z = p.z;

            x = (p.x * Math.Cos(angle)) - (p.y * Math.Sin(angle));
            y = (p.x * Math.Sin(angle)) + (p.y * Math.Cos(angle));
            //z = p.y * Math.Cos(angle);

            p.x = x;
            p.y = y;
            //p.z = z;

            return p;
        }

        public static int toDegrees(double radian)
        {
            radian = radian / Math.PI;
            radian = radian * 180;
            return Math.Abs((int)radian);
        }
    }
}
