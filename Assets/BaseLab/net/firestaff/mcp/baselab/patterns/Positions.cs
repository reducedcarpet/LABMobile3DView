

using net.firestaff.mcp.baselab.util;
using System.Collections.Generic;

namespace net.firestaff.mcp.baselab.patterns
{
    public class Positions
    {

        public static int unit_x = 205;
        public static int unit_y = 9;

        public static int center_x = 0;
        public static int center_y = 0;

        public static Point POINT_CENTER = new Point(center_x, center_y);
        public static Point POINT_CENTER_UP = new Point(center_x, center_y - unit_x);
        public static Point POINT_CENTER_DOWN = new Point(center_x, center_y + unit_x);
        public static Point POINT_CENTER_LEFT = new Point(center_x - unit_x, center_y);
        public static Point POINT_CENTER_RIGHT = new Point(center_x + unit_x, center_y);

        public static Point POINT_CENTER_UP_HALF = new Point(center_x, center_y - (unit_x / 2));
        public static Point POINT_CENTER_DOWN_HALF = new Point(center_x, center_y + (unit_x / 2));
        public static Point POINT_CENTER_LEFT_HALF = new Point(center_x - (unit_x / 2), center_y);
        public static Point POINT_CENTER_RIGHT_HALF = new Point(center_x + (unit_x / 2), center_y);

        public static Point POINT_UP_LEFT = new Point(center_x - unit_x, center_y - unit_x);
        public static Point POINT_UP_RIGHT = new Point(center_x + unit_x, center_y - unit_x);
        public static Point POINT_DOWN_LEFT = new Point(center_x - unit_x, center_y + unit_x);
        public static Point POINT_DOWN_RIGHT = new Point(center_x + unit_x, center_y + unit_x);

        public static Point POINT_UP_LEFT_HALF = new Point(center_x - (unit_x / 2), center_y - (unit_x / 2));
        public static Point POINT_UP_RIGHT_HALF = new Point(center_x + (unit_x / 2), center_y - (unit_x / 2));
        public static Point POINT_DOWN_LEFT_HALF = new Point(center_x - (unit_x / 2), center_y + (unit_x / 2));
        public static Point POINT_DOWN_RIGHT_HALF = new Point(center_x + (unit_x / 2), center_y + (unit_x / 2));

        public static string STRING_CENTER = "center";
        public static string STRING_CENTER_UP = "center_up";
        public static string STRING_CENTER_DOWN = "center_down";
        public static string STRING_CENTER_LEFT = "center_left";
        public static string STRING_CENTER_RIGHT = "center_right";

        public static string STRING_CENTER_UP_HALF = "center_up_half";
        public static string STRING_CENTER_DOWN_HALF = "center_down_half";
        public static string STRING_CENTER_LEFT_HALF = "center_left_half";
        public static string STRING_CENTER_RIGHT_HALF = "center_right_half";

        public static string STRING_UP_LEFT = "up_left";
        public static string STRING_UP_RIGHT = "up_right";
        public static string STRING_DOWN_LEFT = "down_left";
        public static string STRING_DOWN_RIGHT = "down_right";

        public static string STRING_UP_LEFT_HALF = "up_left_half";
        public static string STRING_UP_RIGHT_HALF = "up_right_half";
        public static string STRING_DOWN_LEFT_HALF = "down_left_half";
        public static string STRING_DOWN_RIGHT_HALF = "down_right_half";

        public static Dictionary<string, Point> positionMap = new Dictionary<string, Point>();
        public static Dictionary<Point, string> positionBackMap = new Dictionary<Point, string>();

        public static Point getPosition(string name)
        {
            Point p = POINT_CENTER;
            if (positionMap.ContainsKey(name)) return positionMap[name];
            return p;
        }

        public static string getName(int x, int y)
        {
            Point p = new Point(x, y);
            if (positionBackMap.ContainsKey(p)) return (string)positionBackMap[p];
            return "center";
        }

        public static void initValues(int unit_x_, int unit_y_)
        {
            unit_x = unit_x_;
            unit_y = unit_y_;

            POINT_CENTER = new Point(center_x, center_y);
            POINT_CENTER_UP = new Point(center_x, center_y - unit_x);
            POINT_CENTER_DOWN = new Point(center_x, center_y + unit_x);
            POINT_CENTER_LEFT = new Point(center_x - unit_x, center_y);
            POINT_CENTER_RIGHT = new Point(center_x + unit_x, center_y);

            POINT_CENTER_UP_HALF = new Point(center_x, center_y - (unit_x / 2));
            POINT_CENTER_DOWN_HALF = new Point(center_x, center_y + (unit_x / 2));
            POINT_CENTER_LEFT_HALF = new Point(center_x - (unit_x / 2), center_y);
            POINT_CENTER_RIGHT_HALF = new Point(center_x + (unit_x / 2), center_y);

            POINT_UP_LEFT = new Point(center_x - unit_x, center_y - unit_x);
            POINT_UP_RIGHT = new Point(center_x + unit_x, center_y - unit_x);
            POINT_DOWN_LEFT = new Point(center_x - unit_x, center_y + unit_x);
            POINT_DOWN_RIGHT = new Point(center_x + unit_x, center_y + unit_x);

            POINT_UP_LEFT_HALF = new Point(center_x - (unit_x / 2), center_y - (unit_x / 2));
            POINT_UP_RIGHT_HALF = new Point(center_x + (unit_x / 2), center_y - (unit_x / 2));
            POINT_DOWN_LEFT_HALF = new Point(center_x - (unit_x / 2), center_y + (unit_x / 2));
            POINT_DOWN_RIGHT_HALF = new Point(center_x + (unit_x / 2), center_y + (unit_x / 2));


            positionMap["center"] = POINT_CENTER;
            positionMap["center_up"] = POINT_CENTER_UP;
            positionMap["center_down"] = POINT_CENTER_DOWN;
            positionMap["center_left"] = POINT_CENTER_LEFT;
            positionMap["center_right"] = POINT_CENTER_RIGHT;
            positionMap["center_up_half"] = POINT_CENTER_UP_HALF;
            positionMap["center_down_half"] = POINT_CENTER_DOWN_HALF;
            positionMap["center_left_half"] = POINT_CENTER_LEFT_HALF;
            positionMap["center_right_half"] = POINT_CENTER_RIGHT_HALF;
            positionMap["up_left"] = POINT_UP_LEFT;
            positionMap["up_right"] = POINT_UP_RIGHT;
            positionMap["down_left"] = POINT_DOWN_LEFT;
            positionMap["down_right"] = POINT_DOWN_RIGHT;
            positionMap["up_left_half"] = POINT_UP_LEFT_HALF;
            positionMap["up_right_half"] = POINT_UP_RIGHT_HALF;
            positionMap["down_left_half"] = POINT_DOWN_LEFT_HALF;
            positionMap["down_right_half"] = POINT_DOWN_RIGHT_HALF;

            //List<string> keyList = new List<string>(this.positionMap.Keys);

            foreach (string o in positionMap.Keys)
            {
                positionBackMap[positionMap[o]] = o;
            }

        }

        public string toString()
        {
            string result = "";
            foreach (string o in positionMap.Keys)
            {
                result = result + o + ": x:" + positionMap[o].x + " y:" + positionMap[o].y + "\n";
            }
            return result;
        }
    }
}
