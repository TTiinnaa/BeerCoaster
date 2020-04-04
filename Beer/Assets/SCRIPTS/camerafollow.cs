using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform coaster;
    public Vector3 offset;
    public Vector3 initialpos;
    public Quaternion roation;
    public float ywhenr = 25;
    public float xrot;
    public float factor = 2;
    public bool opp;
    Vector3 newpos;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - coaster.transform.position;
        initialpos = transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (opp)
        {
             newpos = coaster.position + offset;
        }
        else {
             newpos = coaster.position + offset;
        
        }
        
        transform.position = new Vector3(initialpos.x+offset.x, newpos.y, initialpos.z);

        if (transform.position.y > ywhenr)
        {
            xrot = (transform.position.y - ywhenr) * factor;

            if (xrot > 70)
            {
                xrot = 70;
            }
          

            if (opp)
            {

                transform.rotation = new Quaternion(xrot, 0, 0, 180);
            }
            else
            {
                roation.eulerAngles = new Vector3(xrot, -180, 0);
                transform.rotation = roation;
                    
                   
            }

        }
        else {
            if (opp)
            {

                transform.rotation = new Quaternion(0, 0, 0, 180);
            }
            else {
                roation.eulerAngles = new Vector3(0, -180, 0);
                transform.rotation = roation;
            }
            
        
        }
    }
}
