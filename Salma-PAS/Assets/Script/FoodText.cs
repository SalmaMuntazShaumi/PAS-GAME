using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodText : MonoBehaviour
{

    public static float foodValue = 0;
    Text food;
    // Start is called before the first frame update
    void Start()
    {
        food = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        food.text = ("Food : " + foodValue);
    }
}
