using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_3 : MonoBehaviour
{
    public GameObject spawnPrefab;
    private Vector3 spawnPosition = new Vector3(16, 0, 2);
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    void Start ()
    {
        InvokeRepeating("SpawnBox", startDelay, spawnInterval);
    }
    private void SpawnBox()
    {
        Instantiate(spawnPrefab, spawnPosition, spawnPrefab.transform.rotation);
    }
    // Update is called once per frame

}
