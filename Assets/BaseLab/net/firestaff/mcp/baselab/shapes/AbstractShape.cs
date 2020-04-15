

using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;
using UnityEngine; 

using System; 

namespace net.firestaff.mcp.baselab.shapes
{

    public abstract class AbstractShape : Shape
    {
        protected double x;
        protected double y;
        protected double period = Math.PI * 2;
        protected Point p = new Point();
        protected string name;
        public static string shapeName = "shape";
        protected string uiName;
        protected double specialPathRotation;

        public abstract Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier);

        public double getPathRotation()
        {
            return specialPathRotation;
        }

        public double getPeriod()
        {
            return period;
        }

        public string getName()
        {
            return name;
        }

        public static string getShapeName()
        {
            return shapeName;
        }

        public string getUIName()
        {
            return uiName;
        }

        public bool equals(System.Object obj)
        {
            if (!(obj is Shape)) return false;
            return equals((Shape)obj);
        }

        public bool equals(Shape shape)
        {
            if (shape.getName().Equals(this.name)) return true;
            return false;
        }

        public static Shape getNewShape(Shape old)
        {
            
                AbstractShape newShape = (AbstractShape)Activator.CreateInstance(old.GetType());
                newShape.period = old.getPeriod();
                newShape.name = old.getName();
                newShape.specialPathRotation = old.getPathRotation();
                if (old.getName().Equals("VerticalLine")) newShape = new Line(true);
                // TODO change for puased shapes
                return newShape;

        }

        private static Matrix4x4 reverseMatrix = Matrix4x4.Scale(new Vector3(1f,-1f,1f));

        public static Point reverse(Point p)
        {
            
            // Initialize the array with our Coordinate
            Vector3 res = reverseMatrix.MultiplyPoint3x4(new Vector3((float)p.x, (float)p.y, 0f)); 

            // Use the Matrix to map the points
            //Reverse.TransformPoints(pts);

            Point newPoint = new Point(res.x, res.y);
            return newPoint;
        }
    }
}

