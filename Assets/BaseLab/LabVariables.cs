using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LabVariables : MonoBehaviour
{
    public StringReference propType;

    public StringReference shape;
    public StringReference complexShape;

    public FloatReference pathSizeModifier;
    public IntReference pathDirection;
    public FloatReference pathSpeed;
    public FloatReference pathRotation;
    public FloatReference pathAngleModifier;

    public IntReference propDirection;
    public FloatReference propSpeed;
    public FloatReference propAngleModifier;

    public FloatReference xAdj;
    public FloatReference yAdj;

    public FloatReference pivotX;
    public FloatReference pivotY;

    public StringReference zShape;
    public BooleanReference use3D;
    public FloatReference mod3D;
    public BooleanReference flip3D;
    public BooleanReference twist3D;

    public StringReference path3DMask;
    public StringReference prop3DMask;

    public StringReference speedControl;
    public FloatReference speedChangeModifier;
    public StringReference directionChange;
    public FloatReference directionChangeModifier;

    public StringReference accelerationChange;
    public BooleanReference usePendulums;
    public BooleanReference useGravity;



    // Use this for initialization
    void Start()
    {
        //shape.constantValue = "Circle";
        /* 
        complexShape.constantValue = "";

        pathSizeModifier.constantValue = 1f;

        pathDirection.constantValue = 1;
        pathSpeed.constantValue = 1f;
        pathRotation.constantValue = 0f;
        pathAngleModifier.constantValue = 0f;

        propDirection.constantValue = 1;
        propSpeed.constantValue = 1f;
        propAngleModifier.constantValue = 0f;

        xAdj.constantValue = 0f;
        yAdj.constantValue = 0f;

        pivotX.constantValue = 0.5f;
        pivotY.constantValue = 0.5f;

        zShape.constantValue = "ZCircle";
        use3D.constantValue = false;
        mod3D.constantValue = 0;
        flip3D.constantValue = false;
        twist3D.constantValue = false;

        speedControl.constantValue = "constant";
        speedChangeModifier.constantValue = 0;
        directionChange.constantValue = "NoChange";
        directionChangeModifier.constantValue = 0;

        accelerationChange.constantValue = "None";
        usePendulums.constantValue = false;
        useGravity.constantValue = false;
        /* */
    }

    // Update is called once per frame
    void Update()
    {

    }

}
