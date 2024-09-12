using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola mundo!");
        Debug.Log("Este es el primer videojuego de Sergio");
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        // este último mensaje se reproduce varias veces
        // debido a que está en el bloque Update que "acciona" el código en cada fotograma
        
    }
}
