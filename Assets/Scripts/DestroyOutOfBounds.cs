using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float topBound = 30.0f;
    float lowerBound = -10.0f;

    void Update()
    {
        // if (transform.position.z > topBound)
        // {
        //     Destroy(gameObject);
        // }
        // else if (transform.position.z < lowerBound)
        // {
        //     Destroy(gameObject);
        // }
        if (transform.position.z > topBound ||
            transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
