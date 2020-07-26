using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
{
    public Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DetectPlayerCollisions.lives > 0)
        {
            livesText.text = "Lives = " + DetectPlayerCollisions.lives;
        }
        else
        {
            livesText.text = DestroyOutOfBounds.gameOver;
        }
    }
}
