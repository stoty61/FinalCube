using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadInstruction : MonoBehaviour
{
    public int i;
    public void loadSceneIndex()
    {
        SceneManager.LoadScene("Instructions");
    }
}
