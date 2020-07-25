using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = SpawnManager.spawnPosZ;
    private float lowerBound = -5f;
    private float rightBound = SpawnManager.spawnPosX;
    private float leftBound = SpawnManager.spawnPosX * -1f;
    public static string gameOver = "Game Over!";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Remove doggos that pass out of player's view
        if (transform.position.z > topBound || transform.position.z < lowerBound ||
            transform.position.x > rightBound || transform.position.x < leftBound)
        {
            Debug.Log(gameOver);
            Destroy(gameObject);
        }
        
    }

}
