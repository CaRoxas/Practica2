using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject renacuajo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //Duda
            transform.position = new Vector3(renacuajo.transform.position.x, renacuajo.transform.position.y + 1, renacuajo.transform.position.z - 5);
            renacuajo.transform.LookAt(transform.position);
        }
        else if (Input.GetKeyDown(KeyCode.C)) //Duda
        {
            transform.position = renacuajo.transform.position;
        }
    }
}
