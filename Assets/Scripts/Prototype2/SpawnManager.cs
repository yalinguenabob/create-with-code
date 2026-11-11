using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 17, spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, spawnInterval);
    }

    // Update is called once per fram

    private void SpawnRandomAnimals()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        int indexAnimals = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[indexAnimals], spawnPos, animalPrefabs[indexAnimals].transform.rotation);
    }
}
