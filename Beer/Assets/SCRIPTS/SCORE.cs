using UnityEngine.UI;
using UnityEngine;

public class SCORE : MonoBehaviour
{
    // Start is called before the first frame update
    public infinityflip player;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.points.ToString("0");

    }
}
