using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Jugador : MonoBehaviour
{
    Rigidbody rb;
    public TMP_Text Transcurso;
    float movZ, movX;
    public float speed = 10f;
    bool quiereSaltar = false;
    bool estaSuelo = true;
    int monedas = 9;
    float tiempo = 0;
    public GameObject GameOver;
    public GameObject Final;
    public AudioSource Principal;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Recomendado recoger primero la ficha del enemigo y no perder el tiempo traspasando grandes montañas :D");
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Salto();
        tiempo = tiempo + Time.deltaTime;
    }
    private void FixedUpdate()
    {
        Vector3 nuevaVelocidad = new Vector3(movX * speed, rb.velocity.y, movZ * speed);
        rb.velocity = nuevaVelocidad;
    }
    private void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "Trampolin")
        {
            rb.AddForce(Vector3.up * 6, ForceMode.Impulse);
        }
        if (col.gameObject.tag == "Suelo")
        {
            estaSuelo = true;
        }
        if (col.gameObject.tag == "Muerte")
        {
            PauseGame();
            GameOver.SetActive(true);
            Principal.Stop();
        }
        if (col.gameObject.tag == "Monedas")
        {
            monedas = monedas - 1;
        }
        else if (monedas == 0)
        {
            Final.SetActive(true);
            Transcurso.text = "GG :D Total " + tiempo.ToString();
            Debug.Log(tiempo);
            PauseGame();
        }
    }
    void Movimiento()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
    }
    void Salto()
    {
        if (Input.GetButtonDown("Jump"))
        {
            quiereSaltar = true;
        }
        if (quiereSaltar && estaSuelo)
        {
            rb.AddForce(Vector3.up * 6, ForceMode.Impulse);
            estaSuelo = false;
            quiereSaltar = false;
        }
    }
    void PauseGame ()
    {
        Time.timeScale = 0;
    }
}
