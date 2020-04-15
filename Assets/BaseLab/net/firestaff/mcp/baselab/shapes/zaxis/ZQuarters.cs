using System;

namespace net.firestaff.mcp.baselab.shapes.zaxis {

public class ZQuarters : AbstractZShape {

        override public double draw(double realCircleAngle, double zMod) {
        realCircleAngle = realCircleAngle + zMod;
        double x = 1;
        double circleAngle = Math.Abs (realCircleAngle % ((Math.PI * 4) + (0)));

        if(circleAngle > 0 && circleAngle <= (Math.PI / 2))
        {
            x = 1;
        }
        else if(circleAngle > (Math.PI / 2) && circleAngle <= ((Math.PI)))
        {   // 1 -> 2 move 1
            x = Math.Cos(realCircleAngle  - (Math.PI / 2));
        }
        else if(circleAngle > (Math.PI)  && circleAngle <= ((Math.PI) + (Math.PI / 2) ))
        {   // 2 -> 3 pause 2
            x = 0.1;
        }
        else if(circleAngle > (Math.PI ) + (Math.PI / 2) && circleAngle <= ((Math.PI * 2)))
        {   // 3 -> 4 move 2
            x = Math.Cos(realCircleAngle - (Math.PI));
        }

        else if(circleAngle > (Math.PI * 2)  && circleAngle <= ((Math.PI * 2) + (Math.PI / 2) ))
        {   // 2 -> 3 pause 2
            x = -1;
        }
        else if(circleAngle > (Math.PI * 2) + (Math.PI / 2) && circleAngle <= ((Math.PI * 3)))
        {   // 3 -> 4 move 2
            x = Math.Cos(realCircleAngle - (Math.PI) - (Math.PI / 2));
        }
        else if(circleAngle > (Math.PI * 3)  && circleAngle <= ((Math.PI * 3) + (Math.PI / 2) ))
        {   // 2 -> 3 pause 2
            x = -0.1;
        }
        else if(circleAngle > (Math.PI * 3) + (Math.PI / 2) && circleAngle <= ((Math.PI * 4)))
        {   // 3 -> 4 move 2
            x = Math.Cos(realCircleAngle - (Math.PI * 2));
        }

        // this ain't quarters, it's more like 3/4 1/2
        /*
        if(circleAngle > 0 && circleAngle <= (Math.PI))
        {
            x = 1;
        }
        else if(circleAngle > (Math.PI) && circleAngle <= ((Math.PI) + (Math.PI / 2)))
        {   // 1 -> 2 move 1
            x = Math.Cos(realCircleAngle - Math.PI);
        }
        else if(circleAngle > (Math.PI) + (Math.PI / 2) && circleAngle <= ((Math.PI * 2) + (Math.PI / 2) ))
        {   // 2 -> 3 pause 2
            x = 0;
        }
        else if(circleAngle > (Math.PI * 2) + (Math.PI / 2) && circleAngle <= ((Math.PI * 2) + (Math.PI)))
        {   // 3 -> 4 move 2
            x = Math.Cos(realCircleAngle - (Math.PI * 2));
        }
        else if(circleAngle > (Math.PI * 3) + (0) && circleAngle <= ((Math.PI * 3) + (Math.PI) ))
        {   // 4 -> 5 pause 3
            x = -1;
        }
        else if(circleAngle > (Math.PI * 4) && circleAngle <= ((Math.PI * 4) + (Math.PI / 2)))
        {   // 5 -> 6 move 3
            x = Math.Cos(realCircleAngle - (Math.PI * 3));
        }
        else if(circleAngle > (Math.PI * 4) + (Math.PI / 2) && circleAngle <= ((Math.PI * 5) + (Math.PI / 2)))
        {   // 4 -> 5 pause 4
            x = 0;
        }
        else if(circleAngle > (Math.PI * 5) + (Math.PI / 2) && circleAngle <= ((Math.PI * 6)))
        {   // 5 -> 6 move 4
            x = Math.Cos(realCircleAngle - (Math.PI * 4));
        }
        /**/
        return x;
    }
}

}

