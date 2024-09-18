using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    string nombre = "Sergio", apellido1 = "Pérez", apellido2 = "Alcalde";
    int edad = 19;
    // Start is called before the first frame update
    void Start()
    {
        ConstruirNombre();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ConstruirNombre()
    {
        Debug.Log("La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y tiene " + edad + " años");
    }
}
