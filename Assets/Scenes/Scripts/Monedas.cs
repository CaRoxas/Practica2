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
        //Asignada cada moneda consigo misma y una con el enemigo 
        transform.RotateAround(puntoGiro.transform.position, Vector3.up, 100 * Time.deltaTime);
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
