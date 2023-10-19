using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject renacuajo;
    // Start is called before the first frame update
    void Start()
    {
        renacuajo.transform.LookAt(transform.position);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
