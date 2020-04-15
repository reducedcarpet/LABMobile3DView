using System;

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.decorators;
using net.firestaff.mcp.baselab.shapes.paused;
using net.firestaff.mcp.baselab.shapes.zaxis;

namespace net.firestaff.mcp.baselab.shapes.util
{

    public class ShapeHelper {
        public static Shape getShape(string name) {
            Shape togo = new Circle();

            if (name == null) return togo;
            if (name == "" || name.Equals("None") || name.Equals("none") || name.Equals("")) return togo;

            string shape = name;
            foreach (Shape s in ShapeConstants.shapes) {
                if (s.getName().ToLower().Equals(shape.ToLower())) {
                    togo = s;
                    break;
                }
            }
     

            // Order is important here.
            if (shape.Contains("Paused")) {
                double separation = 0;
                double duration = 0;

                if (shape.Contains("Eighth")) separation = 8;
                else if (shape.Contains("Sixth")) separation = 6;
                else if (shape.Contains("Fifth")) separation = 5;
                else if (shape.Contains("Quarter")) separation = 4;
                else if (shape.Contains("Third")) separation = 3;
                else if (shape.Contains("FullHalf")) separation = (1.0 / 3.0) * 2.0;
                else if (shape.Contains("Half")) separation = 2;
                else if (shape.Contains("Full")) separation = 1;
                else if (shape.Contains("Double")) separation = 0.5;

                if (shape.Contains("Eight8")) duration = Math.PI / 4;
                else if (shape.Contains("Six6")) duration = Math.PI / 3;
                else if (shape.Contains("OneFive")) duration = Math.PI + (Math.PI * 2);
                else if (shape.Contains("Five")) duration = (Math.PI * 2) / 5;
                else if (shape.Contains("Four")) duration = Math.PI / 2;
                else if (shape.Contains("Three")) duration = (Math.PI * 2) / 3;
                else if (shape.Contains("TwoTwo")) duration = Math.PI * 4;
                else if (shape.Contains("Two")) duration = Math.PI;
                else if (shape.Contains("One")) duration = Math.PI * 2;

                if (shape.Contains("PausedCap")) {
                    togo = new PausedCapComplexShape(separation, duration, shape);
                }
                else togo = new PausedComplexShape(separation, duration, shape);
                //System.out.println("Correctly parsed: " + shape + " sep " + separation + " FH: " + shape.Contains("FullHalf") + " " + ((1.0/3.0) * 2.0));
                return togo;
            }

            else if (shape.ToLower().Equals("verticalline")) { togo = ShapeConstants.VERTICAL_LINE; }
            else if (shape.ToLower().Equals("horizontalline")) { togo = ShapeConstants.HORIZONTAL_LINE; }
            else if (shape.ToLower().Equals("line")) { togo = ShapeConstants.HORIZONTAL_LINE; }
            else if (shape.ToLower().Equals("point")) { togo = ShapeConstants.POINT; }

            return AbstractShape.getNewShape(togo);
        }


        public static ZShape getZShape(string zShape) {
            zShape = zShape.Replace("Strict", "");
            if (zShape.Equals("ZCircle")) return new ZCircle();
            else if (zShape.Equals("ZHalfCircle")) return new ZHalfCircle();
            else if (zShape.Equals("ZQuarterCircle")) return new ZQuarters();
            else return new ZCircle();
        }
    }
}
