using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject renacuajo;
    public bool Follow = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // establezco camara
        if (Follow == true)
        {
            transform.position = new Vector3(renacuajo.transform.position.x, renacuajo.transform.position.y + 1, renacuajo.transform.position.z - 5);
     
        }
        else
        {
             transform.position = renacuajo.transform.position;
        }


        // cambio estado
        if (Input.GetKeyDown(KeyCode.C))
        {
            if(Follow == false)
            {
                Follow = true;
            }
            else // follow == true
            {
                Follow = false;
            }
            
        }
    }
}
