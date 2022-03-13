using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useProperty : MonoBehaviour
{
    // property myFirstProperty = new property(); // should be avoid
    
    
    void Start()
    {
        property myFirstProperty = this.gameObject.AddComponent<property>();
        int result = myFirstProperty.MyReadOnlyProperty;
        myFirstProperty.MyWriteOnlyProperty = 44;
        int writeOnlyResult = myFirstProperty.MyWriteOnlyProperty;
        print($"getter value should be 999 : {result}");
        print($"setter value should be 44 : {writeOnlyResult}");
    }

    
}
