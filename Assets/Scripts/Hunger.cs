using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hunger : MonoBehaviour
{
    public Slider slider;

    public int maxHunger;
    private int currentHunger = 0;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = currentHunger;
        slider.maxValue = maxHunger;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHunger(int hunger)
    {
        slider.value += hunger;
        currentHunger += hunger;
        if (currentHunger >= maxHunger)
        {
            Destroy(gameObject, 0.1f);
        }
    }
}
