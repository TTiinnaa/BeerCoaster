using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class WilsonForce : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject Beer;
  
    public float cxpos;
    public float carp;
    public float beerpos;
    public DeviceOrientation ori;
    public GameObject newface;

    void Update() {
        ori = Input.deviceOrientation;
        newface.SetActive(false);
        if( ori == DeviceOrientation.PortraitUpsideDown){
        newface.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider other){
        if (other.tag == "Coaster") {
            
            cxpos = other.transform.position.x;
            beerpos = Beer.transform.position.x;
            if (Math.Abs(cxpos - Beer.transform.position.x) < 5 && ori != DeviceOrientation.PortraitUpsideDown)
            {
                carp = cxpos - Beer.transform.position.x;

                if (beerpos > 7)
                {
                    Beer.transform.position = new Vector3(cxpos - 5, Beer.transform.position.y, Beer.transform.position.z);

                }
                else if (beerpos < -6)
                {
                    Beer.transform.position = new Vector3(cxpos + 7f, Beer.transform.position.y, Beer.transform.position.z);
                }
                else
                {


                    if ((cxpos - Beer.transform.position.x) > 0)
                    {
                        Beer.transform.position = new Vector3(cxpos - 4, Beer.transform.position.y, Beer.transform.position.z);

                    }
                    else
                    {
                        Beer.transform.position = new Vector3(cxpos + 7f, Beer.transform.position.y, Beer.transform.position.z);

                    }

                }


            }

                
            }

               
            
        }


        

    
}
