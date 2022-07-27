using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class WallTrigger : MonoBehaviour
{
    public Collider wall;

    public Transform player;

    public Transform wallPosition;

    void OnTriggerExit(Collider other)
    {
        
        if (Math.Abs(player.position.x) > Math.Abs(wallPosition.position.x))
        {
            wall.isTrigger = false;
        }
        
    }
}
