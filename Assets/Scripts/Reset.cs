using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject player;
   
    void OnTriggerEnter(Collider other) 
    {
        player.GetComponent<Rigidbody>().freezeRotation = false;
        FindObjectOfType<GameManager>().delayEndGame();
    }

}
