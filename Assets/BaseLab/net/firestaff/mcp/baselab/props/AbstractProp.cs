

using net.firestaff.mcp.baselab.shapes;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.shapes.zaxis;
using net.firestaff.mcp.baselab.speeds.acceleration;
using net.firestaff.mcp.baselab.speeds.speed;
using net.firestaff.mcp.baselab.speeds.direction;
using net.firestaff.mcp.baselab.util;

using System; 

using UnityEngine;

namespace net.firestaff.mcp.baselab.props
{

    public abstract class AbstractProp : Prop {

        public double pathSizeModifier = 1;
        public double pathAngle = 0;
        public double pathAngleIncrement = Math.PI / 180;
        public int pathDirection = 1;
        public double pathSpeed = 1 ;
        public double pathRotation = 0;
        public double pathAngleModifier = 0;

        public double propAngle = 0;
        public double propAngleIncrement = Math.PI / 180;
        public int propDirection = 1;
        public double propSpeed = 1;
        public double propAngleModifier = 0;

        public double length = 6;
        public double height = 1;
        public double depth = 1;
        public double xAdjBase = 0;
        public double yAdjBase = 0;
        public double zAdjBase = 0;
        public double xAdj = 0;
        public double yAdj = 0;
        public double zAdj = 0;
        public double pivotX = 0;
        public double pivotY = 0;
        public double pivotZ = 0;

        public Shape shape = new Circle();

        public string designation = "Prop";

        public ZShape zShape = new ZCircle();
        public bool use3D = false;
        public double mod3D = 0;
        public bool flip3D = false;
        public bool twist3D = false;

        public string path3DMask = "110";
        public string prop3DMask = "110";

        private double continuousPropAngle = 0;
        private double continuousPathAngle = 0;
        private double continuousPropAngleNoChange = 0;
        private double continuousPathAngleNoChange = 0;

        private int continuousPropDirection = 1;

        protected Point p;
        protected double x;
        protected double y;
        protected double z; 

        protected double rotateAmount;
        protected double mPivotX;
        protected double mPivotY;
        protected double mPivotZ;

        //public Acceleration accelerationChange = new GravityAcceleration(propAngleIncrement, propSpeed);
        public Direction directionChange = new NoChange();
        public double directionChangeModifier = 0;

        public Acceleration accelerationChange = new ZeroAcceleration();
        public bool usePendulums = false;
        public bool useGravity = false;
        public int slowMotionConstant = 1;

        public Speed speedControl = new ConstantSpeed();
        public double speedChangeModifier = 0;

        double prevRotate = 0;

        public void updateTransform(Transform trans)
        {
            mPivotX = length * pivotX;
            mPivotY = height * pivotY;

            // update //////////////////////////////////////////////////////////////////////////////////
            p = shape.draw(length, pathSizeModifier, pathAngle + (pathAngleModifier), 0);
            //p = Circle.draw3D(length, pathSizeModifier, pathAngle + (pathAngleModifier), 0);

            p = Rotate.rotate(p, (pathRotation + shape.getPathRotation()));

            x = p.x + xAdjBase + (xAdj);// - mPivotX;
            y = p.y + yAdjBase + (yAdj);// - mPivotY - (height / 2);
            z = p.z + zAdjBase + (zAdj);

            prevRotate = rotateAmount; 
            rotateAmount = Point.toDegrees(propAngle + propAngleModifier);
            // end of update ///////////////////////////////////////////////////////////////////////////

            if(flip3D) trans.RotateAround(new Vector3((float)x, 0f, (float)y), Vector3.up, (float)(rotateAmount - prevRotate));
            if (twist3D) trans.RotateAround(new Vector3(0f, (float)x, (float)y), Vector3.right, (float)(rotateAmount - prevRotate));
            trans.RotateAround(new Vector3((float)x, (float)y, (float)z), Vector3.back, (float)(rotateAmount - prevRotate));
            //trans.RotateAround(new Vector3(0f, 0f, (float)z), Vector3.up, (float)Math.Cos(rotateAmount - prevRotate));
            //trans.RotateAround(new Vector3(0f, 0f, (float)z), Vector3.right, (float)Math.Sin(rotateAmount - prevRotate));

            if(use3D && flip3D) trans.SetPositionAndRotation(new Vector3((float)x, 0f, (float)y), trans.rotation);
            else if (use3D && twist3D) trans.SetPositionAndRotation(new Vector3(0f, (float)x, (float)y), trans.rotation);
            else 
            trans.SetPositionAndRotation(new Vector3((float)x, (float)y, (float)z), trans.rotation);
            // gotta change this for PivotPoint

            double velocity = accelerationChange.updateAngle(propAngle, propAngleIncrement, propSpeed, propDirection);
            double speed = 0; //speedControl.updateAngle(continuousPathAngleNoChange, propAngle, propAngleIncrement, propSpeed, propDirection, speedChangeModifier);
            propDirection = directionChange.updateAngle(continuousPropAngleNoChange, continuousPropDirection, directionChangeModifier);

            ////////////////////////////////////////////////////////////////////////////////////////
            // Real update to angle.
            ////////////////////////////////////////////////////////////////////////////////////////////

            propAngle += ((((propAngleIncrement) * propSpeed) + (velocity / slowMotionConstant)) * propDirection) + speed;
            if (usePendulums)
                pathAngle += (((pathAngleIncrement) * pathSpeed) + (velocity / slowMotionConstant)) * pathDirection;
            else
                pathAngle += (((pathAngleIncrement) * pathSpeed) + (Math.Abs(velocity) / slowMotionConstant)) * pathDirection;

            ////////////////////////////////////////////////////////////////////////////////////////

            continuousPropAngle += (((propAngleIncrement) * propSpeed)) * propDirection;
            continuousPathAngle += (((pathAngleIncrement) * pathSpeed)) * pathDirection;

            ////////////////////////////////////////////////////////////////////////////////////////

            continuousPropAngleNoChange += (((propAngleIncrement) * propSpeed));
            continuousPathAngleNoChange += (((pathAngleIncrement) * pathSpeed));

            //return trans;
        }

        public void setComplexShape(string newShape) {
            // exiting a complex shape
            if (newShape != null && (newShape.Equals("") || newShape.ToLower().Equals("None"))) {
                if (shape is ComplexShape) {
                    shape = ((ComplexShape)this.shape).getBaseShape();
                    return;
                }
                //else shape = new Circle();
            }

            Shape bShape = ShapeHelper.getShape(newShape);
            if (bShape is ComplexShape) {
                ComplexShape complex = (ComplexShape)bShape;
                if (shape is ComplexShape){
                    Shape baseShape = ((ComplexShape)shape).getBaseShape();
                    complex.setBaseShape(baseShape);
                    shape = complex;
                }
            else {
                    /* if(shape.getName().Equals("Plus") ||
                             shape.getName().Equals("PlusCorner") ||
                             shape.getName().Equals("HCurve") ||
                             shape.getName().Equals("HCurveFig8") ||
                             shape.getName().Equals("HLine") ||
                             shape.getName().Equals("HLineFig8") ||
                             shape.getName().Equals("HCircle") ||
                             shape.getName().Equals("HCircleFig8") ||
                             shape.getName().Equals("PlusHalf") ||
                             shape.getName().Equals("PlusHalfCap") ){
                         // TODO refactor this to allow for correct selection behaviour
                         shape = new Circle();
                         complex.setBaseShape(this.shape);
                         shape = complex;
                     }
                     else { /**/
                    complex.setBaseShape(this.shape);
                    shape = complex;
                    // }
                }
            }
        }

        public void setShape(Shape newShape) {
            // if the old shape was complex and the new one isn't
            if (shape is ComplexShape) {
                if (newShape.getName().ToLower().Equals("Plus") ||
                        newShape.getName().ToLower().Equals("PlusCorner") ||
                        newShape.getName().ToLower().Equals("HCurve") ||
                        newShape.getName().ToLower().Equals("HCurveFig8") ||
                        newShape.getName().ToLower().Equals("HLine") ||
                        newShape.getName().ToLower().Equals("HLineFig8") ||
                        newShape.getName().ToLower().Equals("HCircle") ||
                        newShape.getName().ToLower().Equals("HCircleFig8") ||
                        newShape.getName().ToLower().Equals("PlusHalf") ||
                        newShape.getName().ToLower().Equals("PlusHalfCap")) {
                    shape = newShape;
                }
                else ((ComplexShape)shape).setBaseShape(newShape);
                return;
            }

            shape = newShape;

        }

        public void reset() {
            continuousPropAngleNoChange = 0;
            continuousPathAngleNoChange = 0;
            continuousPropAngle = 0;
            continuousPathAngle = 0;
            propAngle = 0;
            pathAngle = 0;
            p = new Point();
            x = 0;
            y = 0;
            z = 0;
            rotateAmount = 0;
            mPivotX = 0;
            mPivotY = 0;
        }

        public double getZAxis() {
            if (use3D) {
                double zz = zShape.draw(pathAngle, mod3D);
                //System.out.println("PA: " + Math.Cos(propAngle) + " z: " + zz + " path " + propAngle) ;
                return zz;
            }
            return 1;
        }


        public int getPropDirection() {
            return propDirection;
        }

        public void setPropDirection(int propDirection) {
            continuousPropDirection = propDirection;
            accelerationChange.reset(propDirection);
            this.propDirection = propDirection;
        }
    }
}
