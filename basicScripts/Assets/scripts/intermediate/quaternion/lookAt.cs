using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        // quaternion.LookRotation : Creates a rotation with the specified forward and upwards directions.
        transform.rotation = Quaternion.LookRotation(relativePos);
    }
}
