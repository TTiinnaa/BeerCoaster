using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class rewind : MonoBehaviour
{

    public bool isrewinding = false;
    public Rigidbody coaster;
    public Image stalin;
    List<Pointintime> pointintime;
    public float opa = 0;
    public AudioSource reverse;


    void Start() {
        pointintime = new List<Pointintime>();
        stalin.canvasRenderer.SetAlpha(0);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coaster" && GetComponent<Shake>().flashpoint==false)
        {
            StartRewind();
        
        
        }
    
    }

    void Update() {



        if (coaster.IsSleeping()) {
            StopRewind();
        
        }
        if (GetComponent<Shake>().flashpoint)
        {
            StopRewind();
        }
    
    
    }

    void FixedUpdate() {
        if (isrewinding)
        {
             Rewind();

        }
        else {

            Record();
        }
    
    }

    void StartRewind() {
        isrewinding = true;
        coaster.isKinematic = true;
        reverse.Play();
    }
    void StopRewind()
    {
        stalin.canvasRenderer.SetAlpha(0);
        opa = 0;
        isrewinding = false;
        coaster.isKinematic = false;
    }

    void Rewind()
    {
        opa = opa + 0.01f;
        stalin.canvasRenderer.SetAlpha(opa);
        if (pointintime.Count > 3)
        {
            Pointintime pit = pointintime[0];
            coaster.transform.position = pit.position;
            coaster.transform.rotation = pit.rotation;
            pointintime.RemoveAt(0);
            pointintime.RemoveAt(1);
            //pointintime.RemoveAt(2);
        }
        else {
            StopRewind();
        }


    }


    void Record() {
        if (pointintime.Count > Math.Round(8f * (1f / Time.fixedDeltaTime))) {
            pointintime.RemoveAt(pointintime.Count - 1);
        }


        pointintime.Insert(0, new Pointintime(coaster.transform.position, coaster.transform.rotation));
    
    }
}
