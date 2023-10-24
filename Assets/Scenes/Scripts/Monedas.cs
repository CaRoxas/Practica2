using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    Rigidbody rb;
    ParticleSystem exp;
    public GameObject puntoGiro;
    public float tiempo = 1f;
    public AudioSource FXMonedas;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        FXMonedas = GameObject.Find("FXMonedas").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(puntoGiro.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Explode();
            Destroy(this.gameObject,0.3f);
            FXMonedas.Play();
        }
    }
    void Explode()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
    }
    void PauseGame() 
    {
        Time.timeScale = 0;
    }
}
