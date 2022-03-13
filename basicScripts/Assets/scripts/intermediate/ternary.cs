using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ternary : MonoBehaviour
{
    // Start is called before the first frame update
    int health = 5;
    string message;
    void Start()
    {
        InvokeRepeating("decrease", 1, 1);
    }
    void Update()
    {
        message = health < 0 ? "player dead" : "player alive";
        print(message);
    }

    void decrease() 
    {
        health--;
    }
}
