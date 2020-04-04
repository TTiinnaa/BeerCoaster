using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distributer : MonoBehaviour
{
    public int player1;
    public int player2;
    public Sprite Bornabg;
    public Sprite Pavelbg;
    public Sprite Petrbg;
    public Sprite Niclasbg;
    public Sprite Ivorbg;

    public Image Player1bg;
    public Image Player2bg;

    public GameObject BornaFurybar;
    public GameObject PavelFurybar;
    public GameObject NiclasFurybar;
    public GameObject IvorFurybar;
    public PvPFlip Coaster;


    void Start() {


        BornaFurybar.SetActive(false);
        PavelFurybar.SetActive(false);
        NiclasFurybar.SetActive(false);
        IvorFurybar.SetActive(false);
        switch (player1) { 
            case 1:
                BornaFurybar.SetActive(true);
                Player1bg.sprite = Bornabg;
                break;
            case 2:
                PavelFurybar.SetActive(true);
                Player1bg.sprite = Pavelbg;
                FindObjectOfType<FURYBAD>().setSides(1);
                break;
            case 3:
                Player1bg.sprite = Petrbg;
                FindObjectOfType<AlcoholConsumption>().setSides(1);
                break;
            case 4:
                Player1bg.sprite = Niclasbg;
                NiclasFurybar.SetActive(true);
                break;
            case 5:
                Player1bg.sprite = Ivorbg;
                IvorFurybar.SetActive(true);
                break;
            default:
                BornaFurybar.SetActive(true);
                Player1bg.sprite = Bornabg;

                break;
        
        }
        Debug.Log(player2);
        Debug.Log("player2");
        switch (player2)
        {
            case 1:
                Player2bg.sprite = Bornabg;
                break;
            case 2:
                Debug.Log("fuckm na");
                Player2bg.sprite = Pavelbg;
                //PavelFurybar.SetActive(true);
                //FindObjectOfType<FURYBAD>().setSides(2);
                //PavelFurybar.SetActive(false);
                Debug.Log("fuckm na");
                break;
            case 3:
                Player2bg.sprite = Petrbg;
                //FindObjectOfType<AlcoholConsumption>().setSides(2);
                break;
            case 4:
                Player2bg.sprite = Niclasbg;
                //FindObjectOfType<AlcoholConsumption>().setSides(2);
                break;
            case 5:
                Player2bg.sprite = Ivorbg;
                break;
            default:
                Player2bg.sprite = Bornabg;

                break;

        }
    
    



    }
    public void switchsides(int num)
    {

        BornaFurybar.SetActive(false);
        PavelFurybar.SetActive(false);
        NiclasFurybar.SetActive(false);
        IvorFurybar.SetActive(false);
        Debug.Log("ooooooososaosaosasao");
        Debug.Log(num);
        switch(num){
            case 1:
                BornaFurybar.SetActive(true);
                break;
            case 2:
                PavelFurybar.SetActive(true);
                break;
            case 3:
                break;
            case 4:
                NiclasFurybar.SetActive(true);
                break;
            case 5:
                IvorFurybar.SetActive(true);
                break;
        
    
    }


    }
}
