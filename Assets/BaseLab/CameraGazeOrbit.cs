using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGazeOrbit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}

    [SerializeField] private float distance = 2.5f;
	[SerializeField] private float angleadj = 90f;
	[SerializeField] private float cameraHeight = 1.8f;
    [SerializeField] private bool horizontalOrbit = true;
    [SerializeField] private bool verticalOrbit = false;

    // Update is called once per frame
    void Update () {

        if (horizontalOrbit)
        {
            // Store the Euler rotation of the gameobject.
            var eulerRotation = transform.rotation.eulerAngles;

            eulerRotation.y = -1 * ((Mathf.PI / 180) * UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.Head).eulerAngles.y) - angleadj + 0.5f;

            float x = (distance * Mathf.Cos(eulerRotation.y)) + 0f;
            float z = (distance * Mathf.Sin(eulerRotation.y)) + 0f;

            transform.position = new Vector3(x, transform.position.y, z);
        }
        if (verticalOrbit)
        {
            // Store the Euler rotation of the gameobject.
            var eulerRotation = transform.rotation.eulerAngles;

            eulerRotation.x = 1 * ((Mathf.PI / 180) * UnityEngine.XR.InputTracking.GetLocalRotation(UnityEngine.XR.XRNode.Head).eulerAngles.x) - angleadj + 0.5f;

            float y = (distance * Mathf.Cos(eulerRotation.x)) + cameraHeight;
            float z = (distance * Mathf.Sin(eulerRotation.x)) + 0f;

            transform.position = new Vector3(transform.position.x, y, z);
        }

    }

	public void SwitchVertical()
	{	if (verticalOrbit)
			verticalOrbit = false;
		else
			verticalOrbit = true; 
	}

	public void SwitchHorizontal()
	{	if (horizontalOrbit)
			horizontalOrbit = false;
		else
			horizontalOrbit = true; 
	}

	public void SwitchToVertical()
	{	
		horizontalOrbit = false;
		verticalOrbit = true; 
 	}

	public void SwitchToHorizontal()
	{	
		verticalOrbit = false;
		horizontalOrbit = true; 
	}
}
