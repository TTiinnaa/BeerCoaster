using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinScript : MonoBehaviour
{

    public int skinint = 1;
    public static int skin;
    public GameObject Object;
    public flip Flip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        if (Flip) {
            Debug.Log("Skin is put");
            Flip.skinint = skin;
            Debug.Log(skin);
        
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
                skinint = 3;
                break;
            case 2:
                skinint = 1;
                break;
            case 3:
                skinint = 2;
                break;
        }
        Object.GetComponent<SpiningCoaster>().ChangeSkin(skinint);
    }


    public void play() {
        Debug.Log("thisi sharly");
        skin = skinint;
    }
}
