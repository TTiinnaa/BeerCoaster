using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class darkside : MonoBehaviour
{
    // Start is called before the first frame update
    public Image bg;
    private int color= 255;
    // Update is called once per frame
    void Update()
    {
       
        if(Input.deviceOrientation == DeviceOrientation.FaceUp||Input.deviceOrientation == DeviceOrientation.Portrait){
        color = 255;
        
        }
        if(Input.deviceOrientation == DeviceOrientation.LandscapeLeft||Input.deviceOrientation == DeviceOrientation.LandscapeRight){
        color = 112;
        }
        if(Input.deviceOrientation == DeviceOrientation.FaceDown){
        color = 0;
        }
        bg.color = new Color(color, color , color , 255);
        
    }
}
