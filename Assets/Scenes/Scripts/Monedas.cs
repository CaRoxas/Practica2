using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    Rigidbody rb;
    ParticleSystem exp;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Explode();
            Destroy(this.gameObject,1f);
        }
    }
        void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
    }
}
