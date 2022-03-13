using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overloading : MonoBehaviour
{
    // when call signature differs, Unity allows overloading
    void initEnemey(string _name, int _speed) // different parameter
    {
        print($"enemy {_name} has {_speed}");
    }
    void initEnemey(string _name, bool _canFly) // different parameter
    {
        print($"enemy {_name} can fly? {_canFly}");
    }

}
