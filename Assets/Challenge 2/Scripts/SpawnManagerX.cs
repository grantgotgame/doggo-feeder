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
    private float spawnTimer = 4.0f;
    private float spawnIntervalMin = 3.0f;
    private float spawnIntervalMax = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = startDelay + Random.Range(spawnIntervalMin, spawnIntervalMax);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[0], spawnPos, ballPrefabs[0].transform.rotation);
    }

    private void Update()
    {
        // Countdown ball spawn timer
        spawnTimer -= Time.deltaTime;

        if (spawnTimer < 0)
        {
            SpawnRandomBall();
            // Reset timer
            spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);
        }
        
    }

}
