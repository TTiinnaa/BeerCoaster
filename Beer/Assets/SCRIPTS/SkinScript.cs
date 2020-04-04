using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinScript : MonoBehaviour
{

    public int skinint = 1;
    public static int skin;
    public static int skinp1;
    public static int skinp2;
    public GameObject Object;
    public flip Flip;
    public Pflip pFlip;
    public infinityflip iflip;
    public bool vs = false;
    public PvPFlip pvpflip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {   
        if(vs ==  false){
         if (Flip) {
            Debug.Log("Skin is put");
            Flip.skinint = skin;
            Debug.Log(skin);
        
        }
        if (pFlip)
        {
            Debug.Log("Skin is put");
            pFlip.skinint = skin;
            Debug.Log(skin);

        }
        if (iflip)
        {
            Debug.Log("Skin is put");
            iflip.skinint = skin;
            Debug.Log(skin);

        }
        
        }else{
            pvpflip.skin1 = skinp1;
            pvpflip.skin2 = skinp2;
        
        }
       
    }


   public void nextskin() {
        switch (skinint) { 
            case 1:
                skinint = 2;
                break;
            case 2:
                skinint = 3;
                break;
            case 3:
                skinint = 4;
                break;
            case 4:
                skinint = 1;
                break;
        }
        Object.GetComponent<SpiningCoaster>().ChangeSkin(skinint);
    }
    public void prevskin()
    {
        switch (skinint)
        {
            case 1:
                skinint = 4;
                break;
            case 2:
                skinint = 1;
                break;
            case 3:
                skinint = 2;
                break;
            case 4:
                skinint = 3;
                break;
        }
        Object.GetComponent<SpiningCoaster>().ChangeSkin(skinint);
    }


    public void play() {
        Debug.Log("thisi sharly");
        skin = skinint;
    }
    public void vs1() {

            skinp1 = skinint;
    }
    public void vs2()
    {
            skinp2 = skinint;

    
    }
}
