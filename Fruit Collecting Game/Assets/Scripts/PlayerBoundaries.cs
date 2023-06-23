using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundaries : MonoBehaviour
{


    
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), (transform.position.y),
            transform.position.z);
    }
}
