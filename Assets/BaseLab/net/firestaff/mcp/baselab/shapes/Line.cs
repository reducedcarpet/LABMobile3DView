

using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;
using System;

namespace net.firestaff.mcp.baselab.shapes
{

    public class Line : AbstractShape, Shape
    {

        private bool vertical = false;

        public Line()
        {
            name = "HorizontalLine";
            Line.shapeName = name;
            period = Math.PI * 2;
        }

        public Line(bool vert)
        {
            name = "HorizontalLine";
            if (vert) name = "VerticalLine";
            Line.shapeName = name;
            period = Math.PI * 2;
            vertical = vert;
        }

        override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier)
        {

            // stateless draw method
            if (vertical)
            {
                x = 0;
                y = ((length / 2) * circleModifier) * Math.Sin((circleAngle));
            }
            else
            {
                y = 0;
                x = ((length / 2) * circleModifier) * Math.Cos((circleAngle));
            }
            p.x = x;
            p.y = y;

            return p;
        }
    }
}
