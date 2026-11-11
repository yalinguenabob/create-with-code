using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of camera rotation

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get horizontal input (A/D or Left/Right arrow keys)
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); // Rotate the camera around the Y-axis
    }
}
