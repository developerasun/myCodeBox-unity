using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticVar : MonoBehaviour
{
    // static variable/method means the variable/method belongs to a class only, 
    // not belonging to class instances. 
    // this will makes you use the statics without creating instances. 

    public static int enemyCount = 0; // available without instances
    public int enemyCountWithInstance = 0; // requires an instance
    public static void countEnemy()
    {
        enemyCount++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
