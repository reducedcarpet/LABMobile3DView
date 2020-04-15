using System;

namespace net.firestaff.mcp.baselab.shapes.zaxis
{

    public abstract class AbstractZShape : ZShape
    {

        protected string name;

        public string getName()
        {
            return name;
        }

        public abstract double draw(double one, double two);

        public bool equals(System.Object obj)
        {
            if (!(obj is ZShape)) return false;
            return equals((ZShape)obj);
        }

        public bool equals(ZShape shape)
        {
            if (shape.getName().Equals(this.name)) return true;
            return false;
        }
    }
}
