using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delegateScript : MonoBehaviour
{
    delegate void MyDelegate(int num); // delegate call signature
    MyDelegate myDelegate;
    // Start is called before the first frame update
    void Start()
    {
        myDelegate = PrintNum;
        myDelegate(4);
        myDelegate = DoubleNum;
        myDelegate(55);
    }

    void PrintNum(int num)
    {
        print("Print Num : " + num);
    }
    void DoubleNum(int num)
    {
        print("Doulbe Print Num : " + num);
    }

}
