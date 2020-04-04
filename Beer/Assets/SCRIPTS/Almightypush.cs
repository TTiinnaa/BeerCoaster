using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Almightypush : MonoBehaviour
{
    public Rigidbody Coaster;
    public Transform Beer;
    public AudioSource Pain;
    public flip flip;
    public PvPFlip pvp;
    private bool play = true;


    void Update() {
        if (flip == null)
        {

            if (play && pvp.launch && pvp.activeplayer == 2)
            {
                Pain.Play();
                Debug.Log("pooop");
                play = false;
            }
            if (pvp.launch == false && pvp.activeplayer == 2)
            {
                play = true;

            }


        }
        else {

            if (play && flip.launch)
            {
                Pain.Play();
                play = false;
            }
            if (flip.launch == false)
            {
                play = true;

            }
        
        }
        /*
         

        */
       
        


    
    }

    

    void OnTriggerEnter() {
        if (pvp != null)
        {
            if (pvp.activeplayer == 2)
            {
                Coaster.useGravity = false;

               

                Coaster.useGravity = true;
                Vector3 Diff = Coaster.position - Beer.position;
                Debug.Log(Diff);
                Debug.Log("Diff");
                if (pvp.turns == true)
                {
                    Coaster.AddForce(new Vector3(-Diff.x, -Diff.y, -Diff.z-2), ForceMode.Impulse);
                }
                else {
                    Coaster.AddForce(new Vector3(-Diff.x, -Diff.y, -Diff.z + 2), ForceMode.Impulse);
                }
                
            }
        }
        else {

            Coaster.useGravity = false;

            Coaster.useGravity = true;
            Vector3 Diff = Coaster.position - Beer.position;
            Debug.Log(Diff);
            Debug.Log("Diff");
            Coaster.AddForce(new Vector3(-Diff.x,-Diff.y,-Diff.z-2), ForceMode.Impulse);
        
        }
    }


  
}
