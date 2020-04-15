using System.Collections.Generic;

namespace net.firestaff.mcp.baselab.speeds.direction
{
    public class DirectionConstants
    {

        public static readonly Direction NO_CHANGE = new NoChange();
        public static readonly Direction HALF = new HalfReverseDirection();
        public static readonly Direction FULL = new FullReverseDirection();
        public static readonly Direction QUARTER = new QuarterReverseDirection();
        public static readonly Direction THREEQUARTERS = new ThreeQuarterReverseDirection();

        public static readonly List<Direction> shapes = new List<Direction>();

        static DirectionConstants()
        {
            shapes.Add(NO_CHANGE);
            shapes.Add(HALF);
            shapes.Add(FULL);
            shapes.Add(QUARTER);
            shapes.Add(THREEQUARTERS);

        }
    }
}
