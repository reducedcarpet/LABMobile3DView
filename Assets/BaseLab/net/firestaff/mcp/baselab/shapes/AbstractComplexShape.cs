

using net.firestaff.mcp.baselab.shapes.secondorder;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;

namespace net.firestaff.mcp.baselab.shapes {

    public abstract class AbstractComplexShape : AbstractShape, ComplexShape, Shape {

        protected Shape baseShape = new Circle();

        public Shape getBaseShape() {
            return baseShape;
        }

        public void setBaseShape(Shape shape) {
            this.baseShape = shape;
        }

        protected Point drawShape(double length, double circleModifier, double circleAngle, double circleTurnModifier) {
            if (baseShape.getName().Equals("Hypocycloid")) {
                return HypocycloidReal.drawStateless(length, circleModifier, circleAngle, circleTurnModifier);
            }
            return baseShape.draw(length, circleModifier, circleAngle, circleTurnModifier);
        }
    }
}
