using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class soundButton : MonoBehaviour
{
    GameObject manager;

    public TMP_Text soundText;

    bool active;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("AudioManager");
    }

    void Update() 
    {
        if (manager.GetComponent<AudioSource>().volume == 0.0f)
        {
            soundText.text = "MUSIC: OFF"; 
        }

        if (manager.GetComponent<AudioSource>().volume == 1.0f)
        {
            soundText.text = "MUSIC: ON"; 
        }
    }

}
