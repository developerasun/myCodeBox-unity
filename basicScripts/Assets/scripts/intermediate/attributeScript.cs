using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attributeScript : MonoBehaviour
{
    [Range(-50, 50)] public float speed = 0; // speed ranges from -50 to 50
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
}
