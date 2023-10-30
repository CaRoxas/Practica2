using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemigo : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 2f;
    public GameObject GameOver;
    public AudioSource Principal;
    public GameObject Toggle;
    // Start is called before the first frame update
    void Start()
    {
        /*/if (Toggle = true)
        {
            velocidad = GameManager.Velocidad;
        }
        else
        {
            velocidad = 2f;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(objetivo.position);
        float step = velocidad * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, objetivo.position, step);
    }
    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            PauseGame();
            GameOver.SetActive(true);
            Principal.Stop();
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
    }
}
