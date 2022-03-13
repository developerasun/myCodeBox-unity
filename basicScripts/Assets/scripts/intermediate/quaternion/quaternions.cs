using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaternions : MonoBehaviour
{
    // quaternion in Unity is used to create a smooth rotation effect. 
    // Transform's rotation is stored as quaternion.
    // quaternion's component : x, y, z, and w
    // it's important to note that you should not adjust the components manually since they works together, 
    // rather use alternative methods you can find. Unity converts quaternion to Euler angle for inspector
    // Start is called before the first frame update
    
    void Start()
    {
        // transform.rotation = new Vector3(2,3,3); // error : transform.rotation is a quaternion type. 
        transform.rotation = Quaternion.identity; // set Euler rotation to 0,0,0 or no rotaion    
    }

    
}
