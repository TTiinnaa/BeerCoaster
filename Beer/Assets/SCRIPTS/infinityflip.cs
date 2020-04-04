using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.SceneManagement;

public class infinityflip : MonoBehaviour
{
    // Start is called before the first frame update



    public int player1;


    public GameObject BornaBAR;
    public GameObject PavelBAR;


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

    
    public GameObject beer;
    public int points;
    void Start()
    {

        player1 = FindObjectOfType<Distributer>().player1;

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Lamp")
        {
            rb.useGravity = true;
            rb.freezeRotation = false;
        }
    
    }


    void OnMouseDown()
    {

        if (firstp == false && rb.IsSleeping())
        {

            initialpos = Input.mousePosition;

            firstp = true;
            lastp = true;
            rb.useGravity = true;
        }
    }

    void OnMouseUp()
    {

        if (lastp == true && initialpos != new Vector2(0, 0) && rb.IsSleeping())
        {
            lastpos = Input.mousePosition;
            if (lastpos != initialpos)
            {
                forces = lastpos - initialpos;
            }
            if (firstp != true)
            {
                lastp = false;
            }
        }
        dragging = false;
    }

    void Update()
    {

        player1 = FindObjectOfType<stributer>().player1;

        rb.freezeRotation = false;
       
        switch (player1)
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
            switch (player1)
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

            reset();

            Wherewebou.Play();
        }

        if (launch == false && forces.x != 0 && forces.y != 0)
        {   //where the launching happens

            Vector3 direction;

            direction.x = forces.x;
            direction.y = forces.y / yscaler * ps;
            direction.z = forwardforce * ps;

            Vector3 newpos = transform.position;

                newpos.z = newpos.z - 499;

            rb.AddForceAtPosition(direction, newpos);

            launch = true;

        }
        else
        {
            if (rb.IsSleeping() && launch == true)
            {
                if (rb.transform.position.y > newrb.localScale.y * 1.13 + 0.1 && rb.transform.position.y < newrb.localScale.y * 1.13 + 5.1)
                {
                   // FindObjectOfType<gamemanager>().Completelevel();
                    Vector3 oldpos = beer.transform.position;
                    points = points + 1;
                    float angel = (float)(points / 4f * Math.PI * 2f);
                    beer.transform.SetPositionAndRotation(new Vector3(oldpos.x + 2 * Mathf.Sin(angel)-0.5f ,oldpos.y,oldpos.z+3), Quaternion.Euler(new Vector3(0, 0, 0)));
                    
                    reset();
                }
                else
                {
                    switch (player1)
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
                    reset();


                }
            }


        }


    }


    public void reset()
    {
        Debug.Log("reset");
        firstp = false;
        lastp = true;
        launch = false;
        forces = new Vector3(0, 0, 0);
        rb.useGravity = true;
            rb.transform.SetPositionAndRotation(new Vector3(0f, 0.47f, 49.59f), Quaternion.Euler(new Vector3(0, 0, 0)));



    }
}