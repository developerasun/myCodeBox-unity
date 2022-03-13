using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class property : MonoBehaviour
{
    // property in class provides an encapsulation
    private int myReadOnlyProperty = 999; 
    private int myWriteOnlyProperty = 10; 

    // implement property getter
    public int MyReadOnlyProperty 
    { 
        get 
        {
            return myReadOnlyProperty;
        }
    }
    // implement property setter
    public int MyWriteOnlyProperty 
    { 
        get 
        {
            return myWriteOnlyProperty;
        }
        set
        {
            myWriteOnlyProperty = value;
        }
    }

    // prop : emmet to create a property

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
