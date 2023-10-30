using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iniciar : MonoBehaviour
{
    public GameObject Boton;
    public GameObject Inicio;
    public GameObject Toggle;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveZ(Boton, 50f, 3f).setEaseInElastic();

    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
    }
    public void Empezar ()
    {
        Destroy(Inicio);
    }
    public void VelozOn (bool activado)
    {
        /*/if (Toggle = true)
        {
            GameManager.Velocidad;
        }
        else
        {

        }*/
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }
}
