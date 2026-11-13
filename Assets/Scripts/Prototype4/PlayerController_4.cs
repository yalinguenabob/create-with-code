using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_4 : MonoBehaviour
{
    // palyer movement with rgb input
    private Rigidbody playerRb;
    public float moveSpeed = 5f; // Speed of player movement
    private GameObject focalPoint; // Reference to the focal point for camera rotation
    public bool hasPowerup = false; // Flag to indicate if the player has a powerup
    private float powerupStrength = 15.0f;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerup = true; // Set the powerup flag to true
            Destroy(other.gameObject); // Destroy the powerup object
            StartCoroutine(PowerupCountDownRoutine()); // Start the countdown coroutine for powerup durationzssssz
        }
    }

    private void OnCollisionEnter (Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {

            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            Debug.Log("collided with " + collision.gameObject.name +
                "with powerup set to" + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

    IEnumerator PowerupCountDownRoutine ()
    {
        yield return new WaitForSeconds(7); // Wait for 7 seconds
        hasPowerup = false; // Reset the powerup flag to false
    }
}
