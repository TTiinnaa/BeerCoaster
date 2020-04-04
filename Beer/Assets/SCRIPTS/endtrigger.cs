
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public gamemanager gametrigger;

    void OnTriggerEnter() {
        Debug.Log("HII");
        gametrigger.Completelevel();
    }
}
