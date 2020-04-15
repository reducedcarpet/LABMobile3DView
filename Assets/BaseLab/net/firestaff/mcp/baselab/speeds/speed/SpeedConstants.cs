using net.firestaff.mcp.baselab.speeds.speed;
using System.Collections.Generic;

namespace net.firestaff.mcp.baselab.speeds.speed {
    public class SpeedConstants {

        public static readonly Speed FULL = new FullCC();
        public static readonly Speed THREE_QUARTERS = new ThreeQuarterCC();
        public static readonly Speed HALF = new HalfCC();
        public static readonly Speed QUARTER = new QuarterCC();
        public static readonly Speed CONSTANT = new ConstantSpeed();

        public static readonly Speed QUARTER_HALF = new QuarterHalfCC();
        public static readonly Speed HALF_QUARTER = new HalfQuarterCC();

        public static readonly List<Speed> shapes = new List<Speed>(); 
        
        static SpeedConstants()
        {
            shapes.Add(FULL);
            shapes.Add(THREE_QUARTERS);
            shapes.Add(HALF);
            shapes.Add(QUARTER);
            shapes.Add(CONSTANT);

            shapes.Add(QUARTER_HALF);
            shapes.Add(HALF_QUARTER);
        }
    }
}
