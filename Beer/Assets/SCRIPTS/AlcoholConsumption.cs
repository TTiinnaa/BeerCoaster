using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlcoholConsumption : MonoBehaviour
{
    public int Alcohole = 0;
    public GameObject drink;
    static bool drunk = false;
    public GameObject Daforce;
    public GameObject Anima;

    public Sprite newImage;
    public Image myImagcomp;
    public Image myImagcomp1;
    public Image Imagecomp;
    public PvPFlip pvp;
    public infinityflip infi;
    void Start(){
        Imagecomp = myImagcomp1;
    }

    public void setSides(int num)
    {
        if (num == 1)
        {
          //  Imagecomp = myImagcomp1;

        }
        else
        {

           // Imagecomp = myImagcomp;
        }

    }

    public void DrinkAl(int amount){
        Debug.Log(drink.transform.position.y);

        if (drink.transform.position.y > 20)
        {
            drink.transform.Translate(0, -7.63f / 100 * amount, 0);
        }
        else {
            drink.SetActive(false);
            drunk = true;
            if (drunk)
            {

                //Imagecomp.sprite = newImage;
            if (pvp != null && amount == 0) {
                Debug.Log("Ferb");
                Daforce.SetActive(true);
                Anima.SetActive(true);

                
                if (pvp.activeplayer == 3 && pvp.turns)
                {
                     Imagecomp = myImagcomp1;

                }
                else if (pvp.activeplayer == 3 && pvp.turns == false)
                {
                     Imagecomp = myImagcomp;
                }

                Imagecomp.sprite = newImage;
            }
            if (pvp == null) {
                Daforce.SetActive(true);
                Anima.SetActive(true);
                myImagcomp.sprite = newImage;
            
            }
       }
        }
        
            
    }

}
