using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stributer : MonoBehaviour
{
    public int player1;

    public Sprite Bornabg;
    public Sprite Pavelbg;
    public Sprite Petrbg;
    public Sprite Niclasbg;
    public Sprite Ivorbg;

    public Image Player1bg;


    public GameObject BornaFurybar;
    public GameObject PavelFurybar;
    public GameObject NiclasFurybar;
    public GameObject IvorFurybar;

    void Start()
    {


        BornaFurybar.SetActive(false);
        PavelFurybar.SetActive(false);
        NiclasFurybar.SetActive(false);
        IvorFurybar.SetActive(false);
        switch (player1)
        {
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
      
    }

   
}
