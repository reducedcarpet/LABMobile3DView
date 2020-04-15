namespace net.firestaff.mcp.baselab.shapes.util
{ 

    public interface ComplexShape : Shape
    {

        Shape getBaseShape();

        void setBaseShape(Shape shape);

    }
}
