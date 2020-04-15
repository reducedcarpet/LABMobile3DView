namespace net.firestaff.mcp.baselab.speeds.speed
{

    public abstract class AbstractSpeed : Speed
    {

        protected double upperSpeed = 1;
        protected double lowerSpeed = 0;


        public abstract string getName();

        public abstract double updateAngle(double angle, double propAngle, double increment, double speed, int direction, double mod);

        public void setUpperSpeed(double speed)
        {
            upperSpeed = speed;
        }


        public void setLowerSpeed(double speed)
        {
            lowerSpeed = speed;
        }

        public abstract Speed copy();
    }
}
