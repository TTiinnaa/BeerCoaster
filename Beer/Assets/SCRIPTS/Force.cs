using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody Coaster;
    //public flip flip;
    public PvPFlip pvp;
    public GameObject froce;
    

    public bool once = true;
    void OnTriggerEnter()
    {

        if (pvp == null)
        {
            if (once)
            {
                Coaster.useGravity = false;
                Coaster.velocity = Coaster.velocity / 100;
                once = false;
            }
        }
        else {

            if (once && pvp.activeplayer == 3)
            {
                Coaster.useGravity = false;
                Coaster.velocity = Coaster.velocity / 100;
                once = false;
            }
        }
       
        
        Debug.Log("2u");
    }


   void OnMouseDown(){
        
       if (pvp != null)
       {
           if (pvp.activeplayer == 3 && pvp.player1 == 3 && pvp.turns)
           {
               Debug.Log("mom");
               Coaster.AddForce(0, 0, 400);
               Coaster.useGravity = false;
           }
           else if (pvp.activeplayer == 3 && pvp.player2 == 3 && pvp.turns == false )
           {
               Debug.Log("dad");
               Coaster.AddForce(0, 0, -400);
               Coaster.useGravity = false;
           }
       }
       else {
           Coaster.AddForce(0, 0, 400);
           Coaster.useGravity = false;
       }

    }
   void OnMouseUp()
   {
       Coaster.useGravity = true;
       Coaster.velocity = Coaster.velocity / 100;
       once = true;
   }
}
