using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    //tipo nombre = valor; el valor por defecto en cada tipo son los siguientes 
    //int vidas = 0;
    //string nombrePersonaje = "";
    //bool veneno = false;
    //float porcentajeAcierto = 0.0f;
    //char solucionPuzle = ' ';
    int vidas = 100;
    string nombrePersonaje = "Roger";
    bool veneno = false;
    float porcentajeAcierto = 40.8f;
    char solucionPuzle = 'S';

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola " + nombrePersonaje + ", bienvenido a mi mundo.");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Adios mundo!");
    }
}
