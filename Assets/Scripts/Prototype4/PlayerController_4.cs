using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_4 : MonoBehaviour
{
    // palyer movement with rgb input
    private Rigidbody playerRb;
    public float moveSpeed = 5f; // Speed of player movement
    private void Awake()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical"); // Get vertical input (W/S or Up/Down arrow keys)
        playerRb.AddForce(Vector3.forward * moveSpeed * forwardInput); // Move the player forward/backward with effet rolling
    }
}
