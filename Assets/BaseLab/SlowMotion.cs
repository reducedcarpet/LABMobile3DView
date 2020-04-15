using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using net.firestaff.mcp.baselab.props;

public class SlowMotion : MonoBehaviour {

	UnityProp L; 
	UnityProp R; 

	public LABControl lab; 

	double propA;
	double pathA;
	
	// Use this for initialization
	void Start () {
		L = lab.L;
		R = lab.R; 
		propA = L.propAngleIncrement;
		pathA = L.pathAngleIncrement;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(2)) {
			
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
	}
}
