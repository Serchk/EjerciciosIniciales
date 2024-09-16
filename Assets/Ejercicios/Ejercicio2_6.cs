using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int vida = 10, poder = 40, escudo = 50;
    int sumaValores, media, cantidadDeValores = 3;
    // Start is called before the first frame update
    void Start()
    {
        sumaValores = vida + poder + escudo;
        media = sumaValores / cantidadDeValores;
        Debug.Log("Vida: " + vida + " || Poder: " + poder + " || Escudo: " + escudo + " || Media: " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
