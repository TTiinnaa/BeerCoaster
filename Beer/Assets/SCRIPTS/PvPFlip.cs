using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.SceneManagement;
public class PvPFlip : MonoBehaviour
{
    // Start is called before the first frame update

    public bool turns = true;

    public int player1;
    public int player2;

    public GameObject BornaBAR;
    public GameObject PavelBAR;

    public int activeplayer;
    public int inactiveplayer;

    public Camera p1;
    public Camera p2;
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
    public double distancefromglass;
    public Transform glass;
    public int skin1;
    public int skin2;
        Material newMat;
    void Start() {

        player1 = FindObjectOfType<Distributer>().player1;
        player2 = FindObjectOfType<Distributer>().player2;

        skinchanger(skin1);

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

            if (firstp != true) {
                lastp = false;
            }
           
        }
        
        dragging = false;

    }

    void Update()
    {

        player1 = FindObjectOfType<Distributer>().player1;
        player2 = FindObjectOfType<Distributer>().player2;





        if (turns)
        {
            activeplayer = player1;
            inactiveplayer = player2;
        }
        else {
            activeplayer = player2;
            inactiveplayer = player1;
        }

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
                    fb.DelFury(25);
                    break;
                case 2:
                    fb2.AddFury(5);
                    break;
                case 3:
                    Alc.DrinkAl(7);
                    break;
                case 4:
                    fb3.Loss(5);
                    break;
                case 5:
                    fb4.AddFury(10);
                    break;
                    
            }
            Debug.Log("bishcjhaisj");

            reset(turns);

            Wherewebou.Play();
        }

        if (launch == false && forces.x != 0 && forces.y != 0 )
        {   //where the launching happens
    
            Vector3 direction;

            direction.x = forces.x;
            direction.y = forces.y / yscaler * ps;
            direction.z = forwardforce * ps;

            Vector3 newpos = transform.position;
            if (turns == true)
            {
                newpos.z = newpos.z - 499;
                
            }
            else {
                newpos.z = newpos.z + 499;
                direction.z = -direction.z;
                direction.x = -direction.x;
            }

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

                    double x1 = glass.position.x;
                    double y1 = glass.position.z;
                    double x2 = rb.transform.position.x;
                    double y2 = rb.transform.position.z;

                    distancefromglass = Math.Sqrt(Math.Pow((x1 - x2), 2)+ Math.Pow((y1 - y2), 2));

                    switch (activeplayer)
                    {
                        case 1:
                            fb.DelFury(Convert.ToInt32(500/distancefromglass));
                            break;
                        case 2:
                            fb2.AddFury(Convert.ToInt32(100 / distancefromglass));
                            break;
                        case 3:
                            Alc.DrinkAl(Convert.ToInt32(150 / distancefromglass));
                            break;
                        case 4:
                            fb3.Loss(Convert.ToInt32(100 / distancefromglass));
                            break;
                        case 5:
                            fb4.AddFury(Convert.ToInt32(200 / distancefromglass));
                            break;
                    }
                    //Debug.Log("colkk");

                    reset(turns);

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
        if (turn == false)
        {
            rb.transform.SetPositionAndRotation(new Vector3(0f, 0.47f, 49.59f), Quaternion.Euler(new Vector3(0, 0, 0)));
            FindObjectOfType<Distributer>().switchsides(inactiveplayer);

            
            p1.enabled = true;
            p2.enabled = false;
            turns = true;
            skinchanger(skin1);
        }
        else {
            rb.transform.SetPositionAndRotation(new Vector3(-0.78f, 0.47f, 81f), Quaternion.Euler(new Vector3(0, 0, 0)));

            FindObjectOfType<Distributer>().switchsides(inactiveplayer);
            
            p2.enabled = true;
            p1.enabled = false;
            turns = false;
            skinchanger(skin2);
        }
       
    }


    public void skinchanger(int skinint)
    {
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

    

}

