using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchImageButton : MonoBehaviour
{
     private Image OffSprite;
     public Image OnSprite;
     private Button but;

     private bool off = true; 
     public void ChangeImage(){
          if (off)
               but.image = OffSprite;
          else {
               but.image = OnSprite;
          }
          off = !off; 
     }

     void Start()
     {
          OffSprite = gameObject.GetComponent<Image>();
          but = gameObject.GetComponent<Button>();
     }
 
     void Update() 
     {
     }
}