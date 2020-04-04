using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiningCoaster : MonoBehaviour
{
    // Start is called before the first frame update
    Material newMat;
    public Transform Coaster;
    public GameObject Object;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Coaster.transform.Rotate(50 * Time.deltaTime, 120 * Time.deltaTime, 50 * Time.deltaTime);
    }

    public void ChangeSkin(int skinint)
    {
        switch(skinint){
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
        }
        Object.GetComponent<MeshRenderer>().material = newMat;
    }
}
