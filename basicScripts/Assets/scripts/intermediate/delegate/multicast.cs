using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multicast : MonoBehaviour
{
    delegate void MyDelegate(); // declare delegate type with call signature
    MyDelegate myDelegate;

    // Start is called before the first frame update
    void Start()
    {
        myDelegate += addTwo; // store one function
        myDelegate += printName; // store one function

        // should do a null check before execution
        if ( myDelegate != null) {
            myDelegate(); // call the addTwo and printName at the same time(stack functions)
        }
    }

    void addTwo()
    {
        print("add two integers : " + 4 + 2 );
    }
    void printName()
    {
        print("Jake Sung");
    }
}
