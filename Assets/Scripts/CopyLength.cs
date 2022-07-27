using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyLength : MonoBehaviour
{
    public Transform ground;

    public Vector3 newSize;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = ground.localScale + newSize;
    }

}
