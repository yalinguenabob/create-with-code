using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBounds = 34f;
    private float lowerBounds = -4f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        if (transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
