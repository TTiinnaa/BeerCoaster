using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starzoom : MonoBehaviour
{

    public Transform Star;
    public int max;
    public float curr;
    // Start is called before the first frame update
    void Start()
    {
        
        curr = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (curr < max)
        {
            curr+=0.02f;
     
            Star.localScale = new Vector3(curr, curr, curr);
        }

    }
}