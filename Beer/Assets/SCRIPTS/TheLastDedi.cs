using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;
public class TheLastDedi : MonoBehaviour
{
    public float timer = 1;

    public Rigidbody coaster;
    public AudioSource push;

    public TextMesh tm;
    public GameObject father;

    public GameObject sw;
    


    void start() {
        
    }

    void OnTriggerEnter(Collider other){
        if (other.tag == "Coaster" && Input.deviceOrientation != DeviceOrientation.FaceDown)
        {
            other.attachedRigidbody.useGravity = false;

            timer -= 0.01f;
            other.attachedRigidbody.velocity = other.attachedRigidbody.velocity / 100;
        }
    }
    void Update() {
        
        if (Input.deviceOrientation == DeviceOrientation.FaceDown)
        {
            father.SetActive(true);
            
            sw.SetActive(true);
        }
        else {
            father.SetActive(false);
            sw.SetActive(false);
        }
        
            
        if (timer < 1 && timer > 0) {
            timer -= Time.deltaTime*2;
        }
        if (timer < 0) {
            timer = 0;
        }
        if (timer == 0) {

            coaster.useGravity = true;
            coaster.AddForce(new Vector3(0, -100, -1), ForceMode.Impulse);
            push.Play();
           timer = 1;
        }
    
    }
}
