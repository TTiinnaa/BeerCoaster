
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.SceneManagement;





public class flip : MonoBehaviour{
    public bool dragging = false;
    float distance;
    public float Throwspeed;
    public float Archspeed;
    public float Speed;
    public Vector2 initialpos;
    public Vector2 lastpos;
    public Vector2 forces;
    public bool firstp = false;
    public bool lastp = true;
    public bool launch = false;
    public Rigidbody rb;
    public float forwardforce;
    public float yscaler;
    public Vector3 Angletor;
    public int ps;

    private Vector3 oldposi;
    private Vector3 newposi;
    public FURYBAD fb;
    public Transform newrb;
    public AudioSource Wherewebou;
    public bool caught = true;
    public AlcoholConsumption Alc;
    public GameObject Object;
    public int skinint;
    Material newMat;
    
   //"Borna",19,60,20,30,69,69

    void Start() {
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
            default:
                newMat = Resources.Load("Haratz", typeof(Material)) as Material;
                break;
        }

        Object.GetComponent<MeshRenderer>().material = newMat;
    
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
                forces = lastpos - initialpos;
            }
            else {
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
       rb.freezeRotation = false;
       //caught = true;
       if (rb.transform.position.y < -10f || rb.transform.position.y > 500f)
        {

            Wherewebou.Play();
            Restart();

            Wherewebou.Play();
        }

        if (launch == false && forces.x != 0 && forces.y != 0 )
        {
            Vector3 direction;

            direction.x = forces.x;
            direction.y = forces.y / yscaler * ps;
            direction.z = forwardforce * ps;

            Vector3 newpos = transform.position;
            newpos.z = newpos.z - 499;
            rb.AddForceAtPosition(direction, newpos);

            launch = true;
            

        }
        else {
            Debug.Log("launched");
            //this.rb.velocity.x < 0.05 && this.rb.velocity.y < 0.05 && this.rb.velocity.z < 0.05
            if (rb.IsSleeping() && launch == true)
            {
                Debug.Log("Red ball is stationary!");
                //&& rb.transform.position.x < 3.2 && rb.transform.position.x > -2.2
                if (rb.transform.position.y > newrb.localScale.y * 1.13 + 0.1 && caught && rb.transform.position.y < newrb.localScale.y * 1.13 + 7.1)
                {
                    Debug.Log("U did it you crzay son of a bitch");
                    FindObjectOfType<gamemanager>().Completelevel();
                }
                else {
                    Debug.Log("Ull get em next time");

                    Restart();
                    //FindObjectOfType<gamemanager>().EndGame();

                
                }
            }
           
        
        }






    }
    public void Restart() {


        switch (SceneManager.GetActiveScene().buildIndex - 2)
        {
            case 1:
                fb.DelFury(50);
                break;
            case 2:
                fb.AddFury(50);
                break;
            case 3:
                Alc.DrinkAl(50);
                break;
            case 4:
                fb.Loss(50);
                break;
            case 5:
                fb.AddFury(50);
                break;
        }
        Debug.Log("colkk");
        firstp = false;
        lastp = true;
        launch = false;
        forces = new Vector3(0, 0, 0);
        rb.useGravity = true;
        rb.velocity = rb.velocity / 1000;
        rb.freezeRotation = true;
        rb.transform.SetPositionAndRotation(new Vector3(0f, 0.47f, 49.59f), Quaternion.Euler(new Vector3(0, 0, 0)));
        Debug.Log(rb.transform.position);
    }

}