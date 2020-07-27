using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float marginOfError;
    private float topBound;
    private float lowerBound;
    private float rightBound;
    private float leftBound;

    // Start is called before the first frame update
    void Start()
    {
        topBound = SpawnManager.spawnPosZTop + marginOfError;
        lowerBound = SpawnManager.spawnPosZBottom - marginOfError;
        rightBound = SpawnManager.spawnPosX + marginOfError;
        leftBound = (SpawnManager.spawnPosX * -1f) - marginOfError;
        if (CompareTag("Doggo"))
        {
            marginOfError = 0;
        }
        else
        {
            marginOfError = 2f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Remove objects that pass out of player's view
        if (transform.position.z > topBound || transform.position.z < lowerBound ||
            transform.position.x > rightBound || transform.position.x < leftBound)
        {
            Destroy(gameObject);
            if (CompareTag("Doggo"))
            { 
            LivesText.lives--;
            }
        }
    }
}
