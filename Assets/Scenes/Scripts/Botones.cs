using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class Botones : MonoBehaviour
{
    public GameObject boton;
    public int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MoverDerecha(int indice)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[indice];
        if (gameObject.tag == "Derecha")
        {
            indice++;
        }
        else if (indice >= 4)
        {
            indice = 0;
        }
    }
    public void MoverIzquierda(int indice)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[indice];
        if (gameObject.tag == "Izquierda")
        {
            indice--;
        }
        else if (indice >= -1)
        {
            indice = 3;
        }
    }
}
