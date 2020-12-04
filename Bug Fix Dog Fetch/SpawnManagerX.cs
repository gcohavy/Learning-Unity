using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    private float spawnMin = 3;
    private float spawnMax = 5;
    private bool isSpawning;
    

    // Start is called before the first frame update
    void Start()
    {
        isSpawning = false;
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    void Update()
    {
        if(!isSpawning)
        {
            float timer = Random.Range(spawnMin, spawnMax);
            Invoke("SpawnRandomBall", timer);
            isSpawning = true;
        }
    }
    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        int randomIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[0].transform.rotation);
        isSpawning = false;
    }

}
