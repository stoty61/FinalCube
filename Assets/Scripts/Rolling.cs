using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rolling : MonoBehaviour
{
    public Rigidbody player;

    public float rotation;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        player.constraints = RigidbodyConstraints.FreezePosition;
        Vector3 roll;
        roll = new Vector3(rotation,0,0);
        player.angularVelocity = roll;
    }
}
