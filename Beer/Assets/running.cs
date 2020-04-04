using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class running : MonoBehaviour
{
    public Transform sonic;
    float s = 0;
    float add = 1;
    
    // Update is called once per frame
    void Update()
    {
        sonic.rotation = new Quaternion(0, -64.55f, s, 180);
        if (s > 10) { 
        add = -1;
        }
        if(s<-10){
            add = 1;
        }
        s = add + s;
    }
}
