using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDystroy : MonoBehaviour
{
    public Slider slider;
    void Awake() {

        DontDestroyOnLoad(slider);
    
    }
}
