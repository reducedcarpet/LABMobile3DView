using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Image))]
public class LinkedImageRotation : MonoBehaviour
{
    private Image m_image;
    public void setAngle(string angle) {
        //transform.Rotate(0f, (float)int.Parse(angle), 0f);
        m_image.fillAmount = ((float)int.Parse(angle) * 1f) / 360f;

        //transform.SetPositionAndRotation(Vector3.zero, Quaternion.Euler(0f, 0f, (float)int.Parse(angle) * -1f));
    }
    // Start is called before the first frame update
    void Start()
    {
         if (m_image == null)
            {
                m_image = GetComponent<Image>();
                            m_image.type = Image.Type.Filled;
                            m_image.fillMethod = Image.FillMethod.Radial360;
                            m_image.fillOrigin = 2;
                            m_image.fillAmount = 0;
                    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
