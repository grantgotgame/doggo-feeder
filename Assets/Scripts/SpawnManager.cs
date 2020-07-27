using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Timing variables
    private float startDelay = 2f;
    private float spawnInterval = 2.5f;

    // Spawn variables for vertical doggos
    private float spawnRangeX = PlayerController.xRange - 1f;
    public static float spawnPosZTop = 20;
    public static float spawnPosZBottom = -5f;

    // Spawn variables for horizontal doggos
    private float spawnRangeZMax = PlayerController.zRangeMax;
    private float spawnRangeZMin = PlayerController.zRangeMin;
    public static float spawnPosX = 22f;

    // Doggo array variables
    public GameObject[] animalPrefabs;
    private int animalIndex;

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
        // Pick a random doggo
        animalIndex = Random.Range(0, animalPrefabs.Length);

        // Pick a random direction to spawn from
        int doggoDirection = Random.Range(0, 4);
        switch (doggoDirection)
        {
            case 0:
                SpawnDoggoTop();
                break;
            case 1:
                SpawnDoggoRight();
                break;
            case 2:
                SpawnDoggoLeft();
                break;
            case 3:
                SpawnDoggoBottom();
                break;
            default:
                break;
        }
    }

    // Spawn a doggo
    void SpawnDoggoTop()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZTop);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 180, 0));
    }
    void SpawnDoggoRight()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, -90, 0));
    }
    void SpawnDoggoLeft()
    {
        Vector3 spawnPos = new Vector3(-spawnPosX, 0, Random.Range(spawnRangeZMin, spawnRangeZMax));
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 90, 0));
    }
    void SpawnDoggoBottom()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZBottom);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 0, 0));
    }

}
