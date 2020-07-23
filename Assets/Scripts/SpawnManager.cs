using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Spawn variables for vertical animals
    private float spawnRangeX = PlayerController.xRange - 1f;
    public static float spawnPosZ = 20;

    // Spawn variables for horizontal animals
    private float spawnRangeZMax = PlayerController.zRangeMax;
    private float spawnRangeZMin = PlayerController.zRangeMin +2f;
    public static float spawnPosX = 22f;

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
        // Call array of all animals
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        //Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0));
    }

}
