using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody lamp;
    public GameObject Thing;
    public Transform lap;
    void Start()
    {
        lamp.useGravity = true;
        lamp.AddForce(Vector3.down*5000);
    }

    void Update() {

        if (lamp.transform.position.y < -100 || lamp.IsSleeping())
        {
            Debug.Log("seln");
            // Thing.transform.position = new Vector3(6.14f, 19.73f, -4.43f);
            //(new Vector3(6.14f, 19.73f, -4.43f), Quaternion.Euler(new Vector3(0, 0, 0)));
            if (lap != null)
            {
                lap.localPosition = new Vector3(0, 0, 0);
                lap.localRotation = Quaternion.Euler(new Vector3(0, 0, -180));
                Debug.Log(lap.position);
                Debug.Log(lamp.position);
                //lap.transform.SetPositionAndRotation(new Vector3(-2, 102, 68), Quaternion.Euler(new Vector3(0, 180, 180)));

            }
            lamp.velocity = lamp.velocity / 100;
            lamp.rotation = Quaternion.Euler(new Vector3(0, 0, -180));
            lamp.freezeRotation = true;


            Debug.Log(lap.transform.position);
            Thing.SetActive(false);
        }
        else {
           if(lamp.transform.position.y > 70) lamp.AddForce(Vector3.down * 1000);
        }
    }
}
