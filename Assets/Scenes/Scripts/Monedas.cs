using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    Rigidbody rb;
    ParticleSystem exp;
    public GameObject puntoGiro;
    public float tiempo = 1f;
    int monedas = 9;
    //public AudioSource FXMonedas;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            Destroy(this.gameObject,0.5f);
            monedas = monedas - 1;
            //FXMonedas.Play();
        }
        else if (monedas == 0)
        {
            PauseGame();
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
