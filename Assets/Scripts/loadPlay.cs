using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadPlay : MonoBehaviour
{
    // Start is called before the first frame update
    public void loading()
    {
        SceneManager.LoadScene("Level 1");
    }
}
