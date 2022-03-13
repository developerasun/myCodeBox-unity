using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunTarget : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        if (health < 30)
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (health < 0) {
            Destroy(gameObject);
        }
    }
}
