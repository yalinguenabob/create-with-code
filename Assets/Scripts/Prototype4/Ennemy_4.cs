using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy_4 : MonoBehaviour
{
    public float speed = 5f; // Speed of the enemy movement
    private GameObject player; // Reference to the player object
    private Rigidbody enemyRb; // Reference to the enemy's Rigidbody component
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); // Find the player object in the scene
        enemyRb = GetComponent<Rigidbody>(); // Get the enemy's Rigidbody component
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed); // Move the enemy towards the player
    }
}
