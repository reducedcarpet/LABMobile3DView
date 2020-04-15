﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StringReference {

    public bool useConstant = true;
    public string constantValue;
    public StringVariable variable;

    public string value
    {
        get { return useConstant ? constantValue : variable.value; }
    }
}

