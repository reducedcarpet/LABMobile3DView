using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCullingMask : MonoBehaviour
{
    private Camera CameraObject; 

    // Start is called before the first frame update
    void Start()
    {
        CameraObject = GetComponent<Camera> ();
        hideFire();
        hideHandTrails(); 
        hideTrails(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space)) 
         {
             Toggle("UI"); 
         }
    }

    public void toggleFire() {
        Toggle("Fire");
    }

    public void toggleTrails() {
        Toggle("Trails");
    }

    public void toggleIK() {
        Toggle("IK");
    }

    public void toggleGrid() {
        Toggle("Grid");
    }

    public void toggleHandTrails() {
        Toggle("HandTrails");
    }

    public void hideFire() {
        Hide("Fire");
    }

    public void hideTrails() {
        Hide("Trails");
    }

    public void hideIK() {
        Hide("IK");
    }

    public void hideGrid() {
        Hide("Grid");
    }

    public void hideHandTrails() {
        Hide("HandTrails");
    }

    public void showFire() {
        Show("Fire");
    }

    public void showTrails() {
        Show("Trails");
    }

    public void showIK() {
        Show("IK");
    }

    public void showGrid() {
        Show("Grid");
    }

    public void showHandTrails() {
        Show("HandTrails");
    }


    private void Show(string layer) {
        CameraObject.cullingMask |= 1 << LayerMask.NameToLayer(layer);
    }
 
    // Turn off the bit using an AND operation with the complement of the shifted int:
    private void Hide(string layer) {
        CameraObject.cullingMask &=  ~(1 << LayerMask.NameToLayer(layer));
    }
 
    // Toggle the bit using a XOR operation:
    private void Toggle(string layer) {
        CameraObject.cullingMask ^= 1 << LayerMask.NameToLayer(layer);
    }
}
