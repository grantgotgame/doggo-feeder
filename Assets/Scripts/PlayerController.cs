using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    public float speed;

    // Player movement variables
    private float horizontalInput;
    private float verticalInput;    

    // Set axes
    private string horizontalAxis = "Horizontal";
    private string verticalAxis = "Vertical";    

    // Player movement ranges
    public static float xRange = 17f;
    public static float zRangeMax = 15f;
    public static float zRangeMin = 0f;

    // Food timer variables
    private float boneTimer = 0;
    private float boneTimerLength = .5f;

    // Food prefab
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Countdown bone timer
        boneTimer -= Time.deltaTime;

        // Throw bones
        if (Input.GetKey(KeyCode.Space) && boneTimer < 0)
        {
            Instantiate(projectilePrefab, transform.position, transform.rotation);
            boneTimer = boneTimerLength; // Reset bone timer
        }

        // Move player
        horizontalInput = Input.GetAxis(horizontalAxis);
        verticalInput = Input.GetAxis(verticalAxis);
        transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0,
            verticalInput * speed * Time.deltaTime);

        // Set player direction
        if (Input.GetAxisRaw(verticalAxis) < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Input.GetAxisRaw(verticalAxis) > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetAxisRaw(horizontalAxis) < 0)
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else if (Input.GetAxisRaw(horizontalAxis) > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }

        // Enforce range for player movement        
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zRangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
        }
        else if (transform.position.z > zRangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
        }
    }

    // Detect collisions with doggos
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Doggo"))
        {
            Destroy(other.gameObject);
            LivesText.lives--;
        }
    }
}
