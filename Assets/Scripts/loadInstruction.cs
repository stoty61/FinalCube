using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneNo : MonoBehaviour
{
    public int i;
    public void loadSceneIndex()
    {
        SceneManager.LoadScene("Instructions");
    }
}
