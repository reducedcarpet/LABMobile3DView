using System; 
using System.Collections;
using System.Collections.Generic;

using net.firestaff.mcp.baselab.patterns;
using net.firestaff.mcp.baselab.util;

using UnityEngine;

public class URLStripper : MonoBehaviour {

    public LabVariables left; 
    public LabVariables right; 

    public StringType prop; 

	// Use this for initialization
	void Start () {
        //PlayerSettings.SetPropertyString("emscriptenArgs", "-s DEMANGLE_SUPPORT=1", BuildTargetGroup.WebGL);

        init(left); 
        init(right); 
        
        //System.Diagnostics.Debug.WriteLine("URL: " + Application.absoluteURL); 
        string myurl = Application.absoluteURL;
        //string url = "pattern?rightshape=Line&rightcomplex=GTHalfPlusComplexShape&rightpathsize=1.0&rightpathdir=1&rightpathsp=1.0&rightpathrot=0.0&rightpathamod=9.42477796076938&rightpropdir=1&rightpropsp=1.0&rightpropamod=14.137166941154069&rightxadj=0&rightyadj=0&rightpivx=0.0&rightpivy=0.0&rightzshape=&rightmod3d=0.0&rightspc=Constant&rightspmod=0.0&rightdirc=NoChange&rightdirmod=0.0&leftshape=Circle&leftcomplex=GTHalfPlusComplexShape&leftpathsize=1.0&leftpathdir=-1&leftpathsp=1.0&leftpathrot=0.0&leftpathamod=3.141592653589793&leftpropdir=-1&leftpropsp=1.0&leftpropamod=6.283185307179586&leftxadj=0&leftyadj=0&leftpivx=0.0&leftpivy=0.0&leftzshape=&leftmod3d=0.0&leftspc=Constant&leftspmod=0.0&leftdirc=NoChange&leftdirmod=0.0";

        int pm = myurl.IndexOf("?");
        if (pm != -1)
        {
            parseURL(Application.absoluteURL);
            //parseURL(url);
        }
    }
	
    bool loaded = false; 

	void Update () {
        
    }

    void init(LabVariables l) {
        

        l.shape.constantValue = "Circle";
         
        l.complexShape.constantValue = "";

        l.pathSizeModifier.constantValue = 1f;

        l.pathDirection.constantValue = 1;
        l.pathSpeed.constantValue = 1f;
        l.pathRotation.constantValue = 0f;
        l.pathAngleModifier.constantValue = 0f;

        l.propDirection.constantValue = 1;
        l.propSpeed.constantValue = 1f;
        l.propAngleModifier.constantValue = 0f;

        l.xAdj.constantValue = 0f;
        l.yAdj.constantValue = 0f;

        l.pivotX.constantValue = 0.5f;
        l.pivotY.constantValue = 0.5f;

        l.zShape.constantValue = "ZCircle";
        l.use3D.constantValue = false;
        l.mod3D.constantValue = 0;
        l.flip3D.constantValue = false;
        l.twist3D.constantValue = false;

        l.speedControl.constantValue = "constant";
        l.speedChangeModifier.constantValue = 0;
        l.directionChange.constantValue = "NoChange";
        l.directionChangeModifier.constantValue = 0;

        l.accelerationChange.constantValue = "None";
        l.usePendulums.constantValue = false;
        l.useGravity.constantValue = false;
    }

    void parseURL(string url) {
        //Uri url = new Uri(Application.absoluteURL);
        string myurl = url.Split('?')[1];

        prop.propType = "Poi";

        string[] vars = myurl.Split('&');
        for(int i = 0; i < vars.Length; i++) {
            string[] parts =  vars[i].Split('=');
            string name = parts[0];
            System.Diagnostics.Debug.WriteLine("Parts: " + vars[i]); 
            System.Diagnostics.Debug.WriteLine("Name: " + parts[1]); 
            if(name.Equals("proptype")) prop.propType = parts[1]; 

            else if(name.Equals("leftshape")) left.shape.constantValue = parts[1]; 
            else if(name.Equals("leftcomplex")) left.complexShape.constantValue = parts[1]; 
            else if(name.Equals("leftpathsize")) left.pathSizeModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftpathdir")) left.pathDirection.constantValue = Convert.ToInt32(parts[1]); 
            else if(name.Equals("leftpathsp")) left.pathSpeed.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftpathrot")) left.pathRotation.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftpathamod")) left.pathAngleModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftpropdir")) left.propDirection.constantValue = Convert.ToInt32(parts[1]); 
            else if(name.Equals("leftpropsp")) left.propSpeed.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftpropamod")) left.propAngleModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftxadj")) left.xAdj.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftyadj")) left.yAdj.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftpivx")) left.pivotX.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftpivy")) left.pivotY.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftzshape")) left.zShape.constantValue = parts[1]; 
            else if(name.Equals("leftuse3d")) left.use3D.constantValue = Convert.ToBoolean(parts[1]); 
            else if(name.Equals("leftmod3d")) left.mod3D.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftflip3d")) left.flip3D.constantValue = Convert.ToBoolean(parts[1]); 
            else if(name.Equals("lefttwist3d")) left.twist3D.constantValue = Convert.ToBoolean(parts[1]); 
            else if(name.Equals("leftspc")) left.speedControl.constantValue = parts[1]; 
            else if(name.Equals("leftspmod")) left.speedChangeModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftdirc")) left.directionChange.constantValue = parts[1]; 
            else if(name.Equals("leftdirmod")) left.directionChangeModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("leftacc")) left.accelerationChange.constantValue = parts[1];
            else if(name.Equals("leftupen")) left.usePendulums.constantValue = Convert.ToBoolean(parts[1]);
            else if(name.Equals("leftugrav")) left.useGravity.constantValue = Convert.ToBoolean(parts[1]);
            else if(name.Equals("leftpos")) {
                Positions.initValues(6, 6); 
                Point p = Positions.getPosition(parts[1]);
                left.xAdj.constantValue = (float)p.x;
                left.yAdj.constantValue = (float)p.y;  
            }

            else if(name.Equals("rightshape")) right.shape.constantValue = parts[1]; 
            else if(name.Equals("rightcomplex")) right.complexShape.constantValue = parts[1]; 
            else if(name.Equals("rightpathsize")) right.pathSizeModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightpathdir")) right.pathDirection.constantValue = Convert.ToInt32(parts[1]); 
            else if(name.Equals("rightpathsp")) right.pathSpeed.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightpathrot")) right.pathRotation.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightpathamod")) right.pathAngleModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightpropdir")) right.propDirection.constantValue = Convert.ToInt32(parts[1]); 
            else if(name.Equals("rightpropsp")) right.propSpeed.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightpropamod")) right.propAngleModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightxadj")) right.xAdj.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightyadj")) right.yAdj.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightpivx")) right.pivotX.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightpivy")) right.pivotY.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightzshape")) right.zShape.constantValue = parts[1]; 
            else if(name.Equals("rightuse3d")) right.use3D.constantValue = Convert.ToBoolean(parts[1]); 
            else if(name.Equals("rightmod3d")) right.mod3D.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightflip3d")) right.flip3D.constantValue = Convert.ToBoolean(parts[1]); 
            else if(name.Equals("righttwist3d")) right.twist3D.constantValue = Convert.ToBoolean(parts[1]); 
            else if(name.Equals("rightspc")) right.speedControl.constantValue = parts[1]; 
            else if(name.Equals("rightspmod")) right.speedChangeModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightdirc")) right.directionChange.constantValue = parts[1]; 
            else if(name.Equals("rightdirmod")) right.directionChangeModifier.constantValue = Convert.ToSingle(parts[1]); 
            else if(name.Equals("rightacc")) right.accelerationChange.constantValue = parts[1];
            else if(name.Equals("rightupen")) right.usePendulums.constantValue = Convert.ToBoolean(parts[1]);
            else if(name.Equals("rightugrav")) right.useGravity.constantValue = Convert.ToBoolean(parts[1]);
            else if(name.Equals("rightpos")) {
                Positions.initValues(6, 6); 
                Point p = Positions.getPosition(parts[1]);
                right.xAdj.constantValue = (float)p.x;
                right.yAdj.constantValue = (float)p.y;  
            }
        }
    }

}
