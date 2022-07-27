using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;

    public float completeDelay = 1f;

    public GameObject completeLevelUI;

    public GameObject deathUI;

    public Movement movement;

    public Transform player;

    public Transform endPoint;

    public void delayEndGame()
    {
        Invoke("EndGame", 1f);
    }
    public void EndGame()
    {
        Invoke("Death", 1.4f);
        Update();
    }

    void Update() 
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (player.position.z < endPoint.position.z)
            {
                deathUI.SetActive(false);
                Restart();
                movement.enabled = true;
            }

            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            
        }
    }

    public void CompleteGame()
    {
        Invoke("CompleteLevel", completeDelay);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Death()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        deathUI.SetActive(true);
        
    }

    public void CompleteLevel()
    {
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        player.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
        completeLevelUI.SetActive(true);
        
    }
}
