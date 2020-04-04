using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gamemanager : MonoBehaviour
{

    bool GameHasEnded = false;

    public float delay = 1;

    public GameObject completeLevelUI;

    public void Completelevel() {
        Debug.Log("uwin");
        Invoke("win", 4);
        
    }

    public void EndGame() {
        if (GameHasEnded == false) {
            Debug.Log("hi");
            GameHasEnded = true;
            Invoke("Restart", delay);
          
        }
        
    }


    public void Restart()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void win()
    {
        completeLevelUI.SetActive(true);
    }

}
