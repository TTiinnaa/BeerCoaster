using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public hand hand;
    
    void OnTriggerEnter(){
        hand.enabled = true;
    }
}
