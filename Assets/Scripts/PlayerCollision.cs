using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Movement movement;

    public Rigidbody rb;

    public GameObject fallen;

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "Respawn")
        {
            movement.enabled = false;
            rb.freezeRotation = false;
            fallen.SetActive(false);
            FindObjectOfType<GameManager>().EndGame();
            
        }

    }

}
