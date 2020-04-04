using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sonic;
    public float meter = 0;
    public bool flashpoint = false;
    public AudioSource gota;
     Vector3 op;
    void Start()
    {
        op = new Vector3(-9.68f, 6.9f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        sonic.transform.position = new Vector3(op.x, op.y, op.z + meter * 3);
        if (Input.acceleration.magnitude>5) {
            meter += Input.acceleration.magnitude/2;
            gota.Play();
        
        }
        if (meter>100) { 
            meter = 100;
            flashpoint = true;
        }
        if (flashpoint) {
            meter -= Time.deltaTime*10;
            if (meter < 0) {
                meter = 0;
                flashpoint = false;
            }
        }
    }
}
