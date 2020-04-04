using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niclasult : MonoBehaviour
{
    public flip flip;

    public Rigidbody Coaster;
    public Transform Beer;
    public GameObject plane;
    public bool once = true;
    public AudioSource sound;
    void OnTriggerEnter(Collider other) {
        if (other.tag == "Coaster" && once) { 
            
            Coaster.velocity = Coaster.velocity/100;
            plane.SetActive(true);

            Coaster.transform.SetPositionAndRotation(new Vector3(Beer.position.x, 100, Beer.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
            Coaster.freezeRotation = true;
            once = false;
        }else if (once == false) {
            Coaster.velocity = Coaster.velocity / 100;
            sound.Play();
            Coaster.freezeRotation = false;
            if (plane.active == false) {
                plane.SetActive(true);
                once = true;
            }
        }

        
    }
}
