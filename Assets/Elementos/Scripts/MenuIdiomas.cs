using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuIdiomas : MonoBehaviour
{
    public GameObject Boton;
    public GameObject Arranque;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CambiarEscena (string MenuPrincipal)
    {
        SceneManager.LoadScene (MenuPrincipal);
    }
}
