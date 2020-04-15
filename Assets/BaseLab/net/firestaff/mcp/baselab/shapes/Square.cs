

using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.util;
using System;

namespace net.firestaff.mcp.baselab.shapes
{
    public class Square : AbstractShape, Shape {

    public Square() {
        name = "Square";
        Square.shapeName = name;
        period = Math.PI * 2;
    }

    override public Point draw(double length, double circleModifier, double circleAngle, double circleTurnModifier) {
        circleAngle = circleAngle % (Math.PI * 2.0);

        if(circleAngle <= (Math.PI/2)) {
            y = ((length) * circleModifier) * Math.Sin((circleAngle ));
            x = 0;
        }
        if(circleAngle > (Math.PI/2) && circleAngle <= Math.PI) {
            y = ((length) * circleModifier);
            x = ((length) * circleModifier) * Math.Cos((circleAngle ));
        }
        if(circleAngle > (Math.PI) && circleAngle <= (Math.PI + (Math.PI/2))) {
            y = ((length * circleModifier) ) + (((length) * circleModifier) * Math.Sin((circleAngle )));
            x = -1 * ((length) * circleModifier);
        }
        if(circleAngle > (Math.PI + (Math.PI/2))) {
            y = 0;
            x = (((length) * circleModifier) * Math.Cos((circleAngle ))) - ((length * circleModifier) ) ;
        }

        p.x = x;
        p.y = y;

        return p;
    }
}
}

