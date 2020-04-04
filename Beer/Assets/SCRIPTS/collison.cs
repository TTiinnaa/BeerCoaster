using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison : MonoBehaviour
{
    public playermovment movement;


    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "obstacle")
        {
          movement.enabled = false;
          Debug.Log("hi");
          FindObjectOfType<gamemanager>().EndGame();
        }
       
    }
}
