using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sound : MonoBehaviour
{

    public static sound instance;

    GameObject manager;

    bool active;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        
        manager = GameObject.Find("AudioManager");
    }

    public void change() 
    {

        if (manager.GetComponent<AudioSource>().volume == 0.0f)
        {
            manager.GetComponent<AudioSource>().volume = 1.0f;
        }

        else
        {
            manager.GetComponent<AudioSource>().volume = 0.0f;
        }
    }
        


  
}
