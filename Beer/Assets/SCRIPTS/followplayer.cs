﻿
using UnityEngine;

public class followplayer : MonoBehaviour
{
    public Transform 
        player;
   
    public Vector3 offset;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position+offset;
        
        
    }
}
