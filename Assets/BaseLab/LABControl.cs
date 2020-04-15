using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using net.firestaff.mcp.baselab.props;
using net.firestaff.mcp.baselab.shapes.util;
using net.firestaff.mcp.baselab.speeds.direction;
using net.firestaff.mcp.baselab.speeds.speed;

public class LABControl : MonoBehaviour {

    public LabVariables left;
    public LabVariables right;

    public GameObject leftProp;
    public GameObject rightProp;

    public PropControl leftControl;
    public PropControl rightControl;

    public UnityProp L = new UnityProp();
    public UnityProp R = new UnityProp(); 

    double propA;
	double pathA;

    // Use this for initialization
    void Start () {
        initAll();
	}

    public void initAll() {
        init(L, left);
        init(R, right);

        //leftProp.transform.Rotate(Vector3.back, Point.toDegrees(L.propAngleModifier));
        //rightProp.transform.Rotate(Vector3.back, Point.toDegrees(R.propAngleModifier));
    }

    public void InitAll(string empty) {
        init(L, left);
        init(R, right);
    }


    void init(UnityProp p, LabVariables v) {
        p.pathSizeModifier = v.pathSizeModifier.value; 
        p.pathDirection = v.pathDirection.value;
        p.pathSpeed = v.pathSpeed.value;
        p.pathAngleModifier = v.pathAngleModifier.value;
        p.pathRotation = v.pathRotation.value; 

        p.setPropDirection(v.propDirection.value);
        p.propSpeed = v.propSpeed.value;
        p.propAngleModifier = v.propAngleModifier.value;

        p.xAdj = v.xAdj.value;
        p.yAdj = v.yAdj.value;

        p.use3D = v.use3D.value; 
        p.mod3D = v.mod3D.value; 
        p.flip3D = v.flip3D.value; 
        p.twist3D = v.twist3D.value; 

        p.path3DMask = v.path3DMask.value;
        p.prop3DMask = v.prop3DMask.value;

        p.speedControl = SpeedHelper.getSpeed(v.speedControl.value, 1, 0);
        p.speedChangeModifier = v.speedChangeModifier.value;
        p.directionChange = DirectionHelper.getDirectionControl(v.directionChange.value);
        p.directionChangeModifier = v.directionChangeModifier.value;

        p.setShape(ShapeHelper.getShape(v.shape.value));
        p.setComplexShape(v.complexShape.value);

        propA = L.propAngleIncrement;
		pathA = L.pathAngleIncrement;
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButton(1)) {
			
        	L.pathAngleIncrement = pathA / 8;
          	L.propAngleIncrement = propA / 8;
            R.pathAngleIncrement = pathA / 8;
            R.propAngleIncrement = propA / 8;

		}
		else {
			L.pathAngleIncrement = pathA;
          	L.propAngleIncrement = propA;
            R.pathAngleIncrement = pathA;
            R.propAngleIncrement = propA;
		}

        L.updateTransform(leftProp.transform);
        R.updateTransform(rightProp.transform);

    }

    public void reset() {
        L.reset();
        R.reset(); 
        leftProp.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
        rightProp.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
    }

    public void setSpeed(Slider speed) {
        L.propSpeed = (int)speed.value; 
        L.pathSpeed = (int)speed.value; 
        R.propSpeed = (int)speed.value; 
        R.pathSpeed = (int)speed.value; 
    }

    public void stallLeft() {
        L.pathDirection = -1 * L.pathDirection;
        L.propDirection = -1 * L.propDirection;
        reset(); 
    }

    public void stallRight() {
        R.pathDirection = -1 * R.pathDirection;
        R.propDirection = -1 * R.propDirection;
        reset(); 
    }

    public void setPropStaff() {
        leftControl.propType.constantValue = "staff";
        rightControl.propType.constantValue = "staff";
        leftControl.init();
        rightControl.init(); 
    }

    public void setPropSStaff() {
        leftControl.propType.constantValue = "sstaff";
        rightControl.propType.constantValue = "sstaff";
        leftControl.init();
        rightControl.init(); 
    }

    public void setPropFan() {
        leftControl.propType.constantValue = "fan";
        rightControl.propType.constantValue = "fan";
        leftControl.init();
        rightControl.init(); 
    }

    public void setPropPoi() {
        leftControl.propType.constantValue = "poi";
        rightControl.propType.constantValue = "poi";
        leftControl.init();
        rightControl.init(); 
    }

    public void setPropEccentric() {
        leftControl.propType.constantValue = "eccentric";
        rightControl.propType.constantValue = "eccentric";
        leftControl.init();
        rightControl.init(); 
    }

    public void setPropHoop() {
        leftControl.propType.constantValue = "hoop";
        rightControl.propType.constantValue = "hoop";
        leftControl.init();
        rightControl.init(); 
    }

    public void setPropClub() {
        leftControl.propType.constantValue = "club";
        rightControl.propType.constantValue = "club";
        leftControl.init();
        rightControl.init(); 
    }

}
