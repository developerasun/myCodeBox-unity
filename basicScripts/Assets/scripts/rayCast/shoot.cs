using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float damage = 10f; 
    public float range = 100f;
    private Rigidbody rb;
    public float speed = 4;
    // public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical"); 
        // Rigidbody.velocity : change of Rigidbody position.
        rb.velocity = new Vector3(h * speed,0,v*speed);
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire() 
    {
        // ParticleSystem.Play : Starts the Particle System.
        muzzleFlash.Play();
        RaycastHit hit; // RaycastHit : struct type
        bool isHit = Physics.Raycast(
            this.transform.position,
            this.transform.forward, 
            out hit, // no explicit return but value is updated.
            range
        ); // Physics : class type, Raycast : 1) origin 2) direction

        if (isHit)
        {
            print($" target : {hit.transform.name}");
            gunTarget target = hit.transform.GetComponent<gunTarget>();
            if (target != null) 
            {
                target.TakeDamage(10f);
            }
            // print();
        } else { 
            print("no ray cast hit");
        }
    }
}


