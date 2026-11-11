using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager_4 : MonoBehaviour
{
    public GameObject ennemyPrefabs;
    private float spawnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
       
        Instantiate(ennemyPrefabs, GenerateSpawnPosition(), ennemyPrefabs.transform.rotation);
    }

    private Vector3 GenerateSpawnPosition()
    {
        float randomX = Random.Range(-spawnRange, spawnRange);
        float randomZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(randomX, 0, randomZ);
        return randomPos;
    }
}
