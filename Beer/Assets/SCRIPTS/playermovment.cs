using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardforce = 20f;
    public float rightforce = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("fuck off bitch");
        rb.useGravity = true;
        

       // rb.AddForce(0,0,250);
       
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.GetKey("d")) {
            rb.AddForce(rightforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
        //    rb.AddForce(0, 10* rightforce * Time.deltaTime, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-rightforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, -10 * rightforce * Time.deltaTime, -10 * rightforce * Time.deltaTime);
        }

        if (rb.position.y < -50) {
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}
