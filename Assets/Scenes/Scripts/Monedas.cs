using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    Rigidbody rb;
    ParticleSystem exp;
    float tiempo;
    public GameObject puntoGiro;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /* Ponerle el punto de giro solo a una moneda cuando tenga el enemigo
        transform.RotateAround(puntoGiro.transform.position, Vector3.up, 20 * Time.deltaTime);
        DUDA*/ 
    }
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Explode();
            Destroy(this.gameObject,0.5f);
        }
    }
    void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
    }
}
