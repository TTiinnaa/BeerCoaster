using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class waterspill : MonoBehaviour
{
    public GameObject Bubble;
    public Slider slider;
    public GameObject Haw;
    public GameObject mesage;
    public GameObject tri;
    private int once =0;
    // Update is called once per frame
    void Update()
    {
        if (Bubbel.FindObjectOfType<Bubbel>().john == 1) {
            slider.value-=Time.deltaTime/4;
            //Debug.Log(slider.value);
            if (Math.Truncate(slider.value * 10) % 2 == 1)
            {
                Haw.GetComponent<Image>().color = new Color32(255, 255, 225, 225);
            }
            else {
                Haw.GetComponent<Image>().color = new Color32(241, 116, 103, 225);
            
            }


            if (slider.value < 0.1f && once == 0) {
                mesage.SetActive(true);
                tri.SetActive(true);
                Haw.transform.Rotate(0, 0, -90);
                once = 1;
            }
              

        }
         
    }
}
