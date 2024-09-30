using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    string nombre = "Pepe";
    int vida = 20;
    float experiencia = 10;
    // Start is called before the first frame update
    void Start()
    {
        float nivel = CalcularNivel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float CalcularNivel()
    {
        float lvl = experiencia / 1000;
        return lvl;
    }
}
