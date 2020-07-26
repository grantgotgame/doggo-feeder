using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectPlayerCollisions : MonoBehaviour
{
    private string playerGameOver = DestroyOutOfBounds.gameOver;
    public static int lives = 3;

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
            lives--;            
        }
    }
}
