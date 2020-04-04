using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.SceneManagement;
public class Pflip : MonoBehaviour
{
    // Start is called before the first frame update

    public bool turns = true;

    public int player1;
 

    public GameObject BornaBAR;
    public GameObject PavelBAR;

    public int activeplayer;


    public Camera p1;
 
    public bool dragging = false;

    public Vector2 initialpos;
    public Vector2 lastpos;
    public Vector2 forces;
    public bool firstp = false;
    public bool lastp = true;
    public bool launch = false;
    public Rigidbody rb;

    public float forwardforce;
    public float yscaler;

    public int ps;

    private Vector3 oldposi;
    private Vector3 newposi;
    public FURYBAD fb;
    public FURYBAD fb2;
    public FURYBAD fb3;
    public FURYBAD fb4;
    public Transform newrb;
    public AudioSource Wherewebou;

    public AlcoholConsumption Alc;

    public int skinint;
    Material newMat;

    void Start() {

        player1 = FindObjectOfType<stributer>().player1;
        switch (skinint)
        {
            case 1:
                newMat = Resources.Load("Haratz", typeof(Material)) as Material;
                break;
            case 2:
                newMat = Resources.Load("Asia", typeof(Material)) as Material;
                break;
            case 3:
                newMat = Resources.Load("Aisz", typeof(Material)) as Material;
                break;
            case 4:
                newMat = Resources.Load("Beer", typeof(Material)) as Material;
                break;
            default:
                newMat = Resources.Load("Haratz", typeof(Material)) as Material;
                break;
        }

       GetComponent<MeshRenderer>().material = newMat;
    }


    void OnMouseDown() {

        if (firstp == false && rb.IsSleeping())
        {

            initialpos = Input.mousePosition;

            firstp = true;
            lastp = true;
            rb.useGravity = true;
        }
    }

    void OnMouseUp() {

        if (lastp == true && initialpos != new Vector2(0, 0) && rb.IsSleeping())
        {

            lastpos = Input.mousePosition;
            if (lastpos != initialpos)
            {
                Debug.Log("lol buuuu");
                forces = lastpos - initialpos;
            }
            else
            {
                Debug.Log("borna");
                Vector3 direction;

                direction.x = forces.x;
                direction.y = forces.y / yscaler * ps;
                direction.z = forwardforce * ps;

                Vector3 newpos = transform.position;
                newpos.z = newpos.z - 1;
                rb.AddForceAtPosition(direction, newpos);

                launch = true;
                //caught = true;
                rb.useGravity = true;
                // FindObjectOfType<gamemanager>().EndGame();
            }

            if (firstp != true) {
                lastp = false;
            }
           
        }
        
        dragging = false;

    }

    void Update()
    {

        player1 = FindObjectOfType<stributer>().player1;

       activeplayer = player1;


        switch (activeplayer)
        {
            case 1:
                fb.DelFury(0);
                break;
            case 2:
                fb2.AddFury(0);
                break;
            case 3:

                Alc.DrinkAl(0);
                break;
            case 4:
                fb3.Loss(0);
                break;
            case 5:
                fb4.AddFury(0);
                break;
        }

        
        if (rb.transform.position.y < -10f)
        {

            Wherewebou.Play();
            switch (activeplayer)
            {
                case 1:
                    fb.DelFury(10);
                    break;
                case 2:
                    fb2.AddFury(10);
                    break;
                case 3:
                    Alc.DrinkAl(10);
                break;
                case 4:
                    fb3.Loss(50);
                    break;
                case 5:
                    fb4.AddFury(50);
                    break;
                    
            }
            Debug.Log("bishcjhaisj");

            reset(true);

            Wherewebou.Play();
        }

        if (launch == false && forces.x != 0 && forces.y != 0 )
        {   //where the launching happens
    
            Vector3 direction;

            direction.x = forces.x;
            direction.y = forces.y / yscaler * ps;
            direction.z = forwardforce * ps;

            Vector3 newpos = transform.position;

                newpos.z = newpos.z - 499;
                
           
            rb.AddForceAtPosition(direction, newpos);
            
            launch = true;
            //Debug.Log("launching");

        }
        else {
            //Debug.Log("launched");
            //this.rb.velocity.x < 0.05 && this.rb.velocity.y < 0.05 && this.rb.velocity.z < 0.05
            if (rb.IsSleeping() && launch == true)
            {
                //Debug.Log("Red ball is stationary!");
                //&& rb.transform.position.x < 3.2 && rb.transform.position.x > -2.2
                if (rb.transform.position.y > newrb.localScale.y*1.13+0.1 )
                {
                    //Debug.Log("U did it you crzay son of a bitch");
                    FindObjectOfType<gamemanager>().Completelevel();
                }
                else {
                    //Debug.Log("Ull get em next time");

                    switch (activeplayer)
                    {
                        case 1:
                            fb.DelFury(50);
                            break;
                        case 2:
                            fb2.AddFury(50);
                            break;
                        case 3:
                            Alc.DrinkAl(50);
                            break;
                        case 4:
                            fb3.Loss(50);
                            break;
                        case 5:
                            fb4.AddFury(50);
                            break;
                    }
                    //Debug.Log("colkk");

                    reset(true);

                    //Debug.Log(rb.transform.position);
                    //FindObjectOfType<gamemanager>().EndGame();

                
                }
            }
           
        
        }


}


    public void reset(bool turn)
    {
        Debug.Log("reset");
        firstp = false;
        lastp = true;
        launch = false;
        forces = new Vector3(0, 0, 0);
        rb.transform.SetPositionAndRotation(new Vector3(0f, 0.47f, 49.59f), Quaternion.Euler(new Vector3(0, 0, 0)));

           
    }
}


