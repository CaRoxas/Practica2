using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject renacuajo;
    bool Follow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(renacuajo.transform.position.x, renacuajo.transform.position.y + 1, renacuajo.transform.position.z - 5);
        if (Input.GetKeyDown(KeyCode.C))
        {
            transform.position = renacuajo.transform.position;
        }
    }
}
