using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Iniciar : MonoBehaviour
{
    public GameObject Boton;
    public GameObject Inicio;
    public GameObject Toggle;
    public AudioSource Carga;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.moveX(Boton, 20f, 8f).setEaseInBack().setRepeat(60);
        Carga.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CambiarEscena(string Jueguito)
    {
        SceneManager.LoadScene(Jueguito);
        Carga.Stop();
    }
    public void VelozOn (bool activado)
    {
        Debug.Log(activado);

        if (activado == true)
        {
            GameManager.Velocidad = 5;
        }
        else
        {
            GameManager.Velocidad = 2;
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }
    void RestartGame()
    {
        Time.timeScale = 1;
    }
}
