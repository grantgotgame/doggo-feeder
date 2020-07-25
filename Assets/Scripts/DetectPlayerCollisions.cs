using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollisions : MonoBehaviour
{
    private string playerGameOver = DestroyOutOfBounds.gameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Doggo"))
        {
            Destroy(other.gameObject);
            Debug.Log(playerGameOver);
        }
    }
}
