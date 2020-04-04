using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour
{
    public GameObject plane;
    public Vector3 diff;
    public Vector3 end;

    void Start() {
        plane.transform.position = new Vector3(0, 55, 104);
        end = new Vector3(0, -34.1f, -8.9f);
        diff = new Vector3(0, 55, 104) - end;
    }
    void Update() {
        if (plane.transform.position.z > end.z) {
            plane.transform.Translate(-diff / 5 * Time.deltaTime, Space.World);
        
        }else{
        plane.transform.position = new Vector3(0, 55, 104);
        plane.SetActive(false);
        
        }
      
            
        
    }
}
