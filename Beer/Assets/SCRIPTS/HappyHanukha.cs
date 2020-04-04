using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyHanukha : MonoBehaviour
{

    public GameObject Lamp;
    public Rigidbody Coaster;
    public Transform Beer;
    public PvPFlip pvp;
    // Start is called before the first frame update
    private bool once = true;
    void OnTriggerEnter(Collider other) {
        if (pvp != null) {
            if (pvp.activeplayer == 5) {
                Lamp.SetActive(true);
                if (once && other.tag == "Coaster")
                {
                    Coaster.velocity = Coaster.velocity / 100;

                    float oldy = Coaster.transform.position.y;

                    Coaster.transform.SetPositionAndRotation(new Vector3(Beer.position.x, oldy, Beer.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                    Coaster.freezeRotation = true;
                    once = false;
            
            
            }
            
            }


        }
        else
        {
            if (Lamp.active == false) {

                Lamp.SetActive(true);
                //Coaster.useGravity = false;
                Debug.Log("memorys");
                Coaster.velocity = Coaster.velocity / 50;

                float oldy = Coaster.transform.position.y;
                Coaster.transform.position = new Vector3(Beer.position.x, oldy, Beer.position.z);
                //Coaster.transform.SetPositionAndRotation(new Vector3(Beer.position.x, oldy, Beer.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
                //Coaster.freezeRotation = true;
                Coaster.useGravity = false;
                //once = false;
            
            }
           
        }
        
    }
}
