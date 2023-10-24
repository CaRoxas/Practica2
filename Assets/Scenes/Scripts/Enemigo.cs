using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Transform objetivo;
    public float velocidad = 50f;
    public GameObject GameOver;
    public AudioSource Principal;
    // Start is called before the first frame update
    void Start()
    {
        
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
