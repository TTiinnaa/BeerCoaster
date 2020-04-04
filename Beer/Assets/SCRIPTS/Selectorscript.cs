using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Selectorscript : MonoBehaviour
{

    public GameObject Borna;
    public GameObject Pavel;
    public GameObject Petr;
    public GameObject Niclas;
    public GameObject Ivor;
    private Vector3 Charactorpos;
    private Vector3 Charactorposs;
    public int charint = 1;
    private SpriteRenderer BornaR;
    private SpriteRenderer PavelR;
    private SpriteRenderer PetrR;
    private SpriteRenderer NiclasR;
    private SpriteRenderer IvorR;
    public Charinfo charinfo;



    private void Awake() {
        Charactorpos = Borna.transform.position;
        Charactorposs = Pavel.transform.position;

        BornaR = Borna.GetComponent<SpriteRenderer>();
        PavelR = Pavel.GetComponent<SpriteRenderer>();
        PetrR = Petr.GetComponent<SpriteRenderer>();
        NiclasR = Niclas.GetComponent<SpriteRenderer>();
        IvorR = Niclas.GetComponent<SpriteRenderer>();
    }

    public void nextchar() {
        BornaR.enabled = false;
        Borna.transform.position = Charactorposs;

        PavelR.enabled = false;
        Pavel.transform.position = Charactorposs;

        PetrR.enabled = false;
        Petr.transform.position = Charactorposs;

        NiclasR.enabled = false;
        Niclas.transform.position = Charactorposs;

        IvorR.enabled = false;
        Ivor.transform.position = Charactorposs;
        switch(charint){

            


            case 1:

                PavelR.enabled = true;
                Pavel.transform.position = Charactorpos;

                charint ++ ;
                charinfo.ChangeText(charint);
                break;
            case 2:


                PetrR.enabled = true;
                Petr.transform.position = Charactorpos;

                charint++;
                charinfo.ChangeText(charint);
                break;
            case 3:
                NiclasR.enabled = true;
                Niclas.transform.position = Charactorpos;



                charint++;
                charinfo.ChangeText(charint);
                
                break;

            case 4:
                IvorR.enabled = true;
                Ivor.transform.position = Charactorpos;



                charint++;
                charinfo.ChangeText(charint);

                break;


            case 5:
                BornaR.enabled = true;
                Borna.transform.position = Charactorpos;

                charint = 1;
                charinfo.ChangeText(charint);

                break;
                
            default:
                break;
        
        }
    
    }


    public void prevchar()
    {

        BornaR.enabled = false;
        Borna.transform.position = Charactorposs;

        PavelR.enabled = false;
        Pavel.transform.position = Charactorposs;

        PetrR.enabled = false;
        Petr.transform.position = Charactorposs;

        NiclasR.enabled = false;
        Niclas.transform.position = Charactorposs;
        IvorR.enabled = false;
        Ivor.transform.position = Charactorposs;
        switch (charint)
        {
            case 1:

                IvorR.enabled = true;
                Ivor.transform.position = Charactorpos;
                charint = 5;
                charinfo.ChangeText(charint);
                break;

            case 2:
                BornaR.enabled = true;
                Borna.transform.position = Charactorpos;


                charint--;
                charinfo.ChangeText(charint);
                break;
            case 3:


                PavelR.enabled = true;
                Pavel.transform.position = Charactorpos;


                charint--;
                charinfo.ChangeText(charint);
                
                break;
            case 4:

                PetrR.enabled = true;
                Petr.transform.position = Charactorpos;

                charint--;
                charinfo.ChangeText(charint);

                break;
            case 5:

                NiclasR.enabled = true;
                Niclas.transform.position = Charactorpos;
                charint--;
                charinfo.ChangeText(charint);
                break;
            default:
                break;

        }

    }

    public void play() {


        SceneManager.LoadScene(charint + 2);

    
    }
}
