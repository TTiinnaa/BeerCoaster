using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FURYBAD : MonoBehaviour
{
    public Slider slider;
    public float fury;
    public Gradient gradient;
    public Image fill;
    public GameObject bornaulti;
    public GameObject Effect;
    public GameObject Ultimate;
    public Sprite newImage;
    public Image myImagcomp;
    public Image myImagcomp1;
    public Image Imagecomp;
    public PvPFlip pvp;
    public infinityflip infi;
    public void AddFury(int f)
    {
       // Debug.Log(slider.value);
        fury = fury + f;
        slider.value = fury;
        //fill.color = gradient.Evaluate(slider.normalizedValue);
        if (fury >  100)
        {
            Pavelulti(f);
            //fury = 100;
            slider.value = fury;
        }
    }

    public void Loss(int f){
        fury = fury - f;
        slider.value = fury;
        if (fury < 10)
        {
            Niclasult(f);
            //fury = 100;
            slider.value = fury;
        }
    }
    public void DelFury(int f)
    {
        // Debug.Log(slider.value);
        fury = fury - f;
        slider.value = fury;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        //Debug.Log(slider.value);
        if (fury < 0) {
            if (pvp == null)
            {
                Invoke("Bornaulti", 0);

            }
            else {
                if (f == 0) {
                    Debug.Log(f);
                    Invoke("Bornaulti", 0);
                }
            
            }
            
            //fury = 100;
            slider.value = fury;
        }
        


    }

    public void Bornaulti() {

        bornaulti.SetActive(true);
    
    }

    public void setSides(int num) {
        if (num == 1) {
            //Imagecomp = myImagcomp1;
        
        }
        if(num == 2){

           // Imagecomp = myImagcomp;
        Debug.Log("hideFlags");
        }
    
    }
    public void Pavelulti(int f)
    {


        if (pvp != null)
        {
            if (f == 0)
            {
                Ultimate.SetActive(true);
                Effect.SetActive(true);
                
                if (pvp.activeplayer == 2 && pvp.turns)
                {
                   Imagecomp = myImagcomp;
                    Debug.Log("osborn");
                }
                else if (pvp.activeplayer == 2 && pvp.turns == false)
                {
                   Imagecomp = myImagcomp1; 
                    Debug.Log("Harry");
                }

                if (newImage != null)
                {
                    Imagecomp.sprite = newImage;
                }
            }
        }
        else
        {
            if (newImage != null)
            {
                myImagcomp.sprite = newImage;
            }

            Ultimate.SetActive(true);
            Effect.SetActive(true);

         

        }

    }



    public void Niclasult(int f) {

        if (pvp != null)
        {
            if (f == 0)
            {
                Debug.Log("yo kuuunigger");
                if (pvp.activeplayer == 4)
                {

                    Ultimate.SetActive(true);
                    Effect.SetActive(true);
                }

            }
        }
        else {
            Debug.Log("yo btich nigger");
            Ultimate.SetActive(true);
            Effect.SetActive(true);
        }

    }
}
