using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class LinkedRotation : MonoBehaviour
{
    public void setAngle(string angle) {
        //transform.Rotate(0f, (float)int.Parse(angle), 0f);
        transform.SetPositionAndRotation(transform.position, Quaternion.Euler(0f, 0f, (float)int.Parse(angle) * -1f));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
