using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public static float xRange = 17f;
    public static float zRangeMax = 15f;
    public static float zRangeMin = 0f;
    private float boneTimer = 0;
    private float boneTimerLength = .5f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {        
        // Move player horizontally
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Move player vertically
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // Countdown bone timer
        boneTimer -= Time.deltaTime;

        // Throw bones
        if (Input.GetKey(KeyCode.Space) && boneTimer <0)
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            // Reset bone timer
            boneTimer = boneTimerLength;
        }

        // Set range for horizontal player movement        
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Set range for vertical player movement        
        if (transform.position.z < zRangeMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMin);
        }
        else if (transform.position.z > zRangeMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeMax);
        }
    }
}
