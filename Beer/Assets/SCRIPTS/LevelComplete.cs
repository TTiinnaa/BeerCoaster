using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() {
        //if (SceneManager.GetActiveScene().buildIndex < 5)
        //{
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
       // else {
            SceneManager.LoadScene(0);
 
        
        //}
       
    
    }
}
