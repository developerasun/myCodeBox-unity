using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overriding : MonoBehaviour
{
    // override and virtual keywords enables us to re-write method in child class
    // from parent class. 

    public class parent 
    {
        // method in parent class is defined as virutal
        public virtual void sayHi()
        {
            print("hi");
        }
    }

    public class child : parent // inherits the parent
    {
        public override void sayHi() // override the method
        {
            print("not hi");
        }
    }
}
