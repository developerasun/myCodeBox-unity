using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutine : MonoBehaviour
{
    // coroutine is a function executed over intervals
    private MeshRenderer mr;

    public Color color1;
    public Color color2;

    void Start () {
        mr = GetComponent<MeshRenderer>();
        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor() {
    
        while (true) {
            
            if (mr.material.color == color1)
                mr.material.color = color2;
            
            else
                mr.material.color = color1;
            
            yield return new WaitForSeconds(3); // tells Unity to pause the script and continue on the next frame.
        }
    }
}
