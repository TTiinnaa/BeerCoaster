using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarIncreaseinSize : MonoBehaviour
{

    public Transform Star;
    public int max;
    public float curr;
    // Start is called before the first frame update
    void Start()
    {
        Star.localScale= new Vector3(1, 1, 1);
        curr = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (curr < max) {
            curr++;
            Star.localScale = new Vector3(curr, curr, curr);
        }
        
    }
}
