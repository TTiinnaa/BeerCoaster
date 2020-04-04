using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VS : MonoBehaviour
{

    public static int play1;
    public static int play2;
    public Selectorscript up;
    public Selectorscript down;
    public Distributer dis;
    public stributer iss;
    public int loadscene;
    // Start is called before the first frame update

    public void Awake() {
        if (dis) {
            dis.player1 = play1;
            dis.player2 = play2;
        }
        if (iss) {
            iss.player1 = play1;
        }

        Debug.Log(play1);
        Debug.Log(play2); 
    }
    
  public void GameOn(){
        play1 = up.charint;
        play2 = down.charint;
        SceneManager.LoadScene(loadscene);
    }
}
