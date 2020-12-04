using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    private float spawnRangeX = 12.0f;
    private float spawnRangeZ = 15.0f;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),1,spawnRangeZ);
        int spawnIndex = Random.Range(0, spawnPrefabs.Length);

        Instantiate(spawnPrefabs[spawnIndex], spawnPos, spawnPrefabs[spawnIndex].transform.rotation);
    }
}
