using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicPeer : MonoBehaviour
{
    public GameObject hand;
    public GameObject Otherhand;
    public AudioClip Audiosource;
    public flip flip;

    public float volume;


    void Start()
    {
        if (Microphone.devices.Length > 0)
        {
            Audiosource = Microphone.Start(Microphone.devices[0], true, 999, 44100);
        }
        else {
            Debug.Log("rip");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (GetMaxVolume() > 0.1f)
        {
            Debug.Log("hiiidasdsa");
            hand.SetActive(true);
            Otherhand.SetActive(false);
            flip.caught = true;


        }
        else {
            //hand.SetActive(true);
            //Otherhand.SetActive(false);
            hand.SetActive(false);
            Otherhand.SetActive(true);
            flip.caught = false;

        }
    }



    float GetMaxVolume() { 
    float maxVolume = 0f;
    float[] volumeData = new float[128];
    int offset = Microphone.GetPosition(Microphone.devices[0]) - 128 + 1;
    if (offset < 0)
    {
        return 0;
    }
    Audiosource.GetData(volumeData, offset);
    for (int i = 0; i < 127; i++) {
        float tempMax = volumeData[i];
        if (maxVolume < tempMax) {
            maxVolume = tempMax;
        }
    }
    return maxVolume;
    }
}
