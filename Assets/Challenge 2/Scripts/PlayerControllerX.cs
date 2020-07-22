using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogTimer = 0;
    private float dogTimerLength = 1f;

    // Update is called once per frame
    void Update()
    {
        // Countdown dog timer
        dogTimer -= Time.deltaTime;
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogTimer < 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Reset dog timer
            dogTimer = dogTimerLength;
        }
    }
}
