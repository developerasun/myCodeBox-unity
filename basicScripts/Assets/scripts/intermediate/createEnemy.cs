using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        initEnemy();
        print($"created enemy : {staticVar.enemyCount}");
        staticVar myVar = this.gameObject.AddComponent<staticVar>();
        myVar.enemyCountWithInstance = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void initEnemy()
    {
        staticVar.countEnemy(); // note that class instance is not needed
    }
}
