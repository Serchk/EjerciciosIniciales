using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    string nombre;
    int vida;
    float experiencia = 10;

    public int Vida { get => vida; set => vida = value; }
    public string Nombre { get => nombre; set => nombre = value; }

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
