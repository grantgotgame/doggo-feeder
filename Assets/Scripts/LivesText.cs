using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesText : MonoBehaviour
{
    public static int lives = 3;
    public Text livesText;
    private string gameOver = "Game Over!";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives > 0)
        {
            livesText.text = "Lives: " + lives;
        }
        else
        {
            livesText.text = gameOver;
        }
    }
}
