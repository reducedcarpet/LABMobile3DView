using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BooleanReference {

	public bool useConstant = true;
    public bool constantValue;
    public BooleanVariable variable; 

    public bool value
    {
        get { return useConstant ? constantValue : variable.value; }
    }
}
