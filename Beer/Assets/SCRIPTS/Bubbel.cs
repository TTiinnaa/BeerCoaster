using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Bubbel : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bubbel;
    public Vector3 sped;
    public AudioSource bbub;
    public AudioSource water;
    //public Sprite after;
    public GameObject Image;
    public int john = 0;



    void Start()
    {
        bubbel.GetComponent<ParticleSystem>().Stop();

    }

    void Update()
    {
        Vector3 dir = Vector3.zero;

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
 
        dir.y = Input.acceleration.y;
        dir.x = Input.acceleration.x;
        dir.z = Input.acceleration.z;

    

        

        if (Math.Abs(dir.y) > 4)
        {
          
            john = 1;
        }
        if (john == 1) {
            Image.SetActive(true);
            water.Play();
        }
       
    }



  
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Coaster" && john == 0) {
            sped = new Vector3(other.attachedRigidbody.velocity.x, other.attachedRigidbody.velocity.y, other.attachedRigidbody.velocity.z);
            other.attachedRigidbody.AddForce(sped.x/10,-sped.y,sped.z*0/7f, ForceMode.Impulse);
            bubbel.GetComponent<ParticleSystem>().Play();
            bbub.Play();
            
            ParticleSystem.EmissionModule em = bubbel.GetComponent<ParticleSystem>().emission;
            em.enabled = true;
        }
    
    }
}
