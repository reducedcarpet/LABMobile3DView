using System;

namespace net.firestaff.mcp.baselab.util
{

    public class Point
    {
        public double x = 0;
        public double y = 0;
        public double z = 0;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point()
        {
        }

        public Point sub(Point v1)
        {
            Point v2 = new Point(this.x - v1.x, this.y - v1.y);
            return v2;
        }

        public static Point sub(Point thi, Point v1)
        {
            Point v2 = new Point(thi.x - v1.x, thi.y - v1.y);
            return v2;
        }

        public float heading()
        {
            float angle = (float)Math.Atan2(y, x);
            return angle;
        }

        public double heading(Point other, double dir_)
        {
            double heading = Math.Atan2(other.x - this.x, other.y - this.y);// - this->dir;
            return heading;
        }

        public void mult(double m)
        {
            x *= m;
            y *= m;
        }

        public Point add(Point v1)
        {
            Point v2 = new Point(this.x + v1.x, this.y + v1.y);
            return v2;
        }

        public void setMagnitude(float len_)
        {
            normalize();
            mult(len_);
        }

        public Point normalize()
        {
            Point v2 = new Point();

            double length = Math.Sqrt(this.x * this.x + this.y * this.y);
            if (length != 0)
            {
                this.x = (this.x / length);
                this.y = (this.y / length);
            }

            return v2;
        }

        public float dist(Point v)
        {
            float dx = (float)(x - v.x);
            float dy = (float)(y - v.y);
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        static public float dist(Point v1, Point v2)
        {
            float dx = (float)(v1.x - v2.x);
            float dy = (float)(v1.y - v2.y);
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }


        public bool equals(System.Object obj)
        {
            if (this == obj) return true;
            if (obj is Point)
            {
                Point p = (Point)obj;
                if (p.x == this.x && p.y == this.y) return true;
            }
            else return false;
            return false;
        }

        public bool equals(Point p)
        {
            if (p.x == this.x && p.y == this.y && p.z == this.z) return true;
            else return false;
        }

        public int hashCode()
        {
            return GetHashCode(); 
        }



        public static double toDegrees(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        public static double toRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}