using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class Botones : MonoBehaviour
{
    public GameObject boton;
    public static int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MoverDerecha()
    {
        indice++;
        if (indice > 3)
        {
            indice = 0;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[indice];
    }
    public void MoverIzquierda()
    {
        indice--;
        if (indice < 0)
        {
            indice = 3;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[indice];
    }
}
