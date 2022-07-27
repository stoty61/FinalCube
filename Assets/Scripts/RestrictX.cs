using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestrictX : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezePositionX;
    }
}
