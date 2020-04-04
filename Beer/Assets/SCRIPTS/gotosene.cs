using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gotosene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gotoPVP() {
        SceneManager.LoadScene(5);
    }
    public void gotoPrac()
    {
        SceneManager.LoadScene(2);
    }
    public void gotoBoss()
    {
        SceneManager.LoadScene(1);
    }
    public void gotoDis()
    {
      //  SceneManager.LoadScene(7);
    }
    public void gotoDrug()
    {
       // SceneManager.LoadScene(3);
    }
    public void gotoBadlang()
    {
       // SceneManager.LoadScene(5);
    }
    public void gotoendless()
    {
        SceneManager.LoadScene(7);
    }
    public void gotoMainmenu()
    {
        SceneManager.LoadScene(0);
    }
}
