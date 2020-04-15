

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes.decorators
{
    public abstract class AbstractDecoratorShape : AbstractComplexShape
    {

        protected new Shape baseShape = new Circle();

        public new Shape getBaseShape()
        {
            return baseShape;
        }

        public new void setBaseShape(Shape shape)
        {
            if (baseShape is ComplexShape) ((ComplexShape)baseShape).setBaseShape(shape);
            else this.baseShape = shape;
        }

        protected new Point drawShape(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            return baseShape.draw(length, circleModifier, circleAngle, circleTurnModifier);
        }
    }
}
