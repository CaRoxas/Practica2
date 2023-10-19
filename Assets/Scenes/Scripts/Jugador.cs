using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    Rigidbody rb;
    float movZ, movX;
    public float speed = 10f;
    bool quiereSaltar;
    bool estaSuelo = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        Salto();
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
            rb.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }   
    }
    void Movimiento()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
    }
    void Salto()
    {
        //Ahora salta solo una vez pero no vuelve a saltar :D
        if (Input.GetButtonDown("Jump"))
        {
            quiereSaltar = true;
        }
        if (quiereSaltar && estaSuelo)
        {
            rb.AddForce(Vector3.up * 6, ForceMode.Impulse);
            estaSuelo = false;
        }
    }
}
