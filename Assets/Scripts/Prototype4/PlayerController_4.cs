using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_4 : MonoBehaviour
{
    // palyer movement with rgb input
    private Rigidbody playerRb;
    public float moveSpeed = 5f; // Speed of player movement
    private GameObject focalPoint; // Reference to the focal point for camera rotation
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point"); // Find the focal point object in the scene
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical"); // Get vertical input (W/S or Up/Down arrow keys)
        playerRb.AddForce(focalPoint.transform.forward * moveSpeed * forwardInput); // Move the player forward/backward with effet rolling
    }
}
