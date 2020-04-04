using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody Coaster;
    public Rigidbody Hand;
    public flip flip;
    public BoxCollider BC;
    void Start() { 
    Hand.transform.SetPositionAndRotation(new Vector3(-3.97f,1.15f,82.91f), Quaternion.Euler(new Vector3(-99.87f,-624.3f,-5.4f)));
    
    }
    void Update() {

        Hand.velocity = Hand.velocity / 100;
        if (flip.launch && Coaster.transform.position.z > 60.80629f && Coaster.transform.position.y < 20.06)
        {
            Vector3 Diff = Hand.transform.position - Coaster.transform.position;
           
            Hand.AddForce(-Diff*800);
        }
       
    
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coaster") {

            Debug.Log("biethch");
            Hand.velocity = Hand.velocity / 100;
            Coaster.useGravity = false;
            Coaster.velocity = Coaster.velocity / 100;
            Coaster.freezeRotation = true;
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.x = 0;
            rotationVector.y = 0;
            Coaster.transform.rotation = Quaternion.Euler(rotationVector);
            Coaster.freezeRotation = true;
            //flip.caught = false;
            Invoke("flip.Restart();", 1);
            //flip.Restart();
        }
      
    }
}
