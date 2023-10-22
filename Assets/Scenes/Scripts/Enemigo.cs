using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject renacuajo;
    private Transform objetivo;
    public float velocidad = 2f;
    // Start is called before the first frame update
    void Start()
    {
        renacuajo.transform.LookAt(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        var step = velocidad * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, step);
    }
}
