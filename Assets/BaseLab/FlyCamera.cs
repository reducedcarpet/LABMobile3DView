﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class FlyCamera : MonoBehaviour
{

    /*
    Writen by Windexglow 11-13-10.  Use it, edit it, steal it I don't care.  
    Converted to C# 27-02-13 - no credit wanted.
    Simple flycam I made, since I couldn't find any others made public.  
    Made simple to use (drag and drop, done) for regular keyboard layout  
    wasd : basic movement
    shift : Makes camera accelerate
    space : Moves camera on X and Z axis only.  So camera doesn't gain any height*/


    float mainSpeed = 100.0f; //regular speed
    float shiftAdd = 250.0f; //multiplied by how long shift is held.  Basically running
    float maxShift = 1000.0f; //Maximum speed when holdin gshift
    float camSens = 0.25f; //How sensitive it with mouse
    private Vector3 lastMouse = new Vector3(255, 255, 255); //kind of in the middle of the screen, rather than at the top (play)
    private float totalRun = 1.0f;

    public float distance = 1f;

    float zAxisValue;

    void Update()
    {
        
        float xAxisValue = Input.GetAxis("Horizontal");
        float yAxisValue = Input.GetAxis("Vertical");
        // if (Input.mouseScrollDelta.y > 0f) 
        zAxisValue = Input.mouseScrollDelta.y * camSens;
        
        if(Camera.current != null && !Input.GetMouseButton(0))
        {
            
            Camera.current.transform.Translate(new Vector3(xAxisValue, yAxisValue, zAxisValue));
            Camera.current.transform.LookAt(Vector3.zero, Vector3.up); 
        } /* */
    
        #if UNITY_ANDROID 

            /*
                if(!Input.GetMouseButton(0)) {
                Vector3 dir = Vector3.zero;

                dir.x = -Input.acceleration.x;
                dir.y = -Input.acceleration.y;

                // clamp acceleration vector to the unit sphere
                if (dir.sqrMagnitude > 1)
                    dir.Normalize();
                dir *= Time.deltaTime;
                // Move object
                transform.Translate (dir * 10);
                transform.LookAt(Vector3.zero, Vector3.up); 
            }    /** */

            float pinchAmount = 0;
            Quaternion desiredRotation = transform.rotation;
        
            DetectMovement.Calculate();
        
            if (Mathf.Abs(DetectMovement.pinchDistanceDelta) > 0) { // zoom
                pinchAmount = DetectMovement.pinchDistanceDelta;
            }
        
            if (Mathf.Abs(DetectMovement.turnAngleDelta) > 0) { // rotate
                Vector3 rotationDeg = Vector3.zero;
                rotationDeg.z = -DetectMovement.turnAngleDelta;
                desiredRotation *= Quaternion.Euler(rotationDeg);
            }
        
        
            // not so sure those will work:
            transform.SetPositionAndRotation(transform.position, desiredRotation);
            transform.position += Vector3.forward * pinchAmount * camSens;  
            transform.LookAt(Vector3.zero, Vector3.up);  
        #endif

    /* 
        if(Camera.current != null && Input.GetMouseButton(0))
        {
            float xAxisValuep = xAxisValue;
            float yAxisValuep = yAxisValue;
            xAxisValue = Input.mousePosition.x - xAxisValuep;
            yAxisValue = Input.mousePosition.y - yAxisValuep;
            Camera.current.transform.Translate(new Vector3(xAxisValue, yAxisValue, zAxisValue));
            Camera.current.transform.LookAt(Vector3.zero, Vector3.up); 
        } /* */

        /*
        if (Input.GetMouseButton(0)) {
            lastMouse = Input.mousePosition - lastMouse;
            lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
            lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
            transform.eulerAngles = lastMouse;
            lastMouse = Input.mousePosition;
            //Mouse  camera angle done.  

            //Keyboard commands
            //float f = 0.0f;
            Vector3 p = GetBaseInput();
            if (Input.GetKey(KeyCode.LeftShift))
            {
                totalRun += Time.deltaTime;
                p = p * totalRun * shiftAdd;
                p.x = Mathf.Clamp(p.x, -maxShift, maxShift);
                p.y = Mathf.Clamp(p.y, -maxShift, maxShift);
                p.z = Mathf.Clamp(p.z, -maxShift, maxShift);
            }
            else
            {
                totalRun = Mathf.Clamp(totalRun * 0.5f, 1f, 1000f);
                p = p * mainSpeed;
            }

            p = p * Time.deltaTime;
            Vector3 newPosition = transform.position;
            if (Input.GetKey(KeyCode.Space))
            { //If player wants to move on X and Z axis only
                transform.Translate(p);
                newPosition.x = transform.position.x;
                newPosition.z = transform.position.z;
                transform.position = newPosition;
            }
            else
            {
                transform.Translate(p);
            }
        }
        /* */
    }

    private Vector3 GetBaseInput()
    { //returns the basic values, if it's 0 than it's not active.
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey(KeyCode.W))
        {
            p_Velocity += new Vector3(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            p_Velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            p_Velocity += new Vector3(1, 0, 0);
        }
        return p_Velocity;
    }
}