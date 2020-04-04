using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossSelect : MonoBehaviour
{
    public GameObject Graham;
    public GameObject Wilson;
    public GameObject Sarha;
    public GameObject Sprilan;
    public GameObject Soldo;
    public int bossint= 1;
    private Vector3 Charactorpos;
    private Vector3 Charactorposs;
    private SpriteRenderer GrahamR;
    private SpriteRenderer WilsonR;
    private SpriteRenderer SarhaR;
    private SpriteRenderer SprilanR;
    private SpriteRenderer SoldoR;
    public Charinfo charinfo;


    private void Awake()
    {
        Charactorpos = Graham.transform.position;
        Charactorposs = Wilson.transform.position;

        GrahamR = Graham.GetComponent<SpriteRenderer>();
        WilsonR = Wilson.GetComponent<SpriteRenderer>();
        SarhaR = Sarha.GetComponent<SpriteRenderer>();
        SprilanR = Sprilan.GetComponent<SpriteRenderer>();
        SoldoR = Soldo.GetComponent<SpriteRenderer>();
    }

    public void nextchar()
    {
        GrahamR.enabled = false;
        Graham.transform.position = Charactorposs;

        WilsonR.enabled = false;
        Wilson.transform.position = Charactorposs;

        SarhaR.enabled = false;
        Sarha.transform.position = Charactorposs;
        SprilanR.enabled = false;
        Sprilan.transform.position = Charactorposs;
        SoldoR.enabled = false;
        Soldo.transform.position = Charactorposs;
        switch (bossint)
        {
            case 1:

                WilsonR.enabled = true;
                Wilson.transform.position = Charactorpos;
                
                bossint++;
                charinfo.ChangeBossText(bossint);
               // charinfo.ChangeText(charint);
                break;


            case 2:

               SarhaR.enabled = true;
                Sarha.transform.position = Charactorpos;
                
                bossint ++;
                charinfo.ChangeBossText(bossint);
                //charinfo.ChangeText(charint);

                break;

            case 3:
                SprilanR.enabled = true;
                Sprilan.transform.position = Charactorpos;

                bossint ++;
                charinfo.ChangeBossText(bossint);
                //charinfo.ChangeText(charint);

                break;

            case 4:
                SoldoR.enabled = true;
                Soldo.transform.position = Charactorpos;

                bossint ++;
                charinfo.ChangeBossText(bossint);
                //charinfo.ChangeText(charint);

                break;
            case 5:
                GrahamR.enabled = true;
                Graham.transform.position = Charactorpos;

                bossint = 1;
                charinfo.ChangeBossText(bossint);
                //charinfo.ChangeText(charint);

                break;
            default:
                break;

        }

    }


    public void prevchar()
    {

        GrahamR.enabled = false;
        Graham.transform.position = Charactorposs;

        WilsonR.enabled = false;
        Wilson.transform.position = Charactorposs;
        SarhaR.enabled = false;
        Sarha.transform.position = Charactorposs;

        SprilanR.enabled = false;
        Sprilan.transform.position = Charactorposs;
        SoldoR.enabled = false;
        Soldo.transform.position = Charactorposs;
        switch (bossint)
        {
            case 4:

                SarhaR.enabled = true;
                Sarha.transform.position = Charactorpos;

                
                bossint--;
                charinfo.ChangeBossText(bossint);
                break;


            case 2:
                GrahamR.enabled = true;
                Graham.transform.position = Charactorpos;
                
                bossint --;
                charinfo.ChangeBossText(bossint);

                break;

            case 3:
                WilsonR.enabled = true;
                Wilson.transform.position = Charactorpos;

                bossint --;
                charinfo.ChangeBossText(bossint);

                break;

            case 5:
                SprilanR.enabled = true;
                Sprilan.transform.position = Charactorpos;

                bossint--;
                charinfo.ChangeBossText(bossint);

                break;

            case 1:
                SoldoR.enabled = true;
                Soldo.transform.position = Charactorpos;

                bossint = 5;
                charinfo.ChangeBossText(bossint);

                break;
            default:
                break;

        }

    }

    public void play()
    {


        SceneManager.LoadScene(bossint + 7);


    }

}
