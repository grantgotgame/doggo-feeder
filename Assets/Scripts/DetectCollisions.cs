using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // If food hits doggo, remove food and doggo
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Doggo"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
