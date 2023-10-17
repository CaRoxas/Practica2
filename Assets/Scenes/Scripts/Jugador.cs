using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    Rigidbody rb;
    float movZ, movX;
    public float speed = 10f;
    bool quiereSaltar;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Jump"))
        {
            quiereSaltar = true;
        }
        if (quiereSaltar)
        {
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            quiereSaltar = false;
        }
    }
        private void FixedUpdate()
    {
        Vector3 nuevaVelocidad = new Vector3(movX * speed, rb.velocity.y, movZ * speed);
        rb.velocity = nuevaVelocidad;
    }
}
