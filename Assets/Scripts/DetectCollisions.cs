using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

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
            ScoreText.score++;
            other.GetComponent<Hunger>().SetHunger(1);
        }

    }
}
