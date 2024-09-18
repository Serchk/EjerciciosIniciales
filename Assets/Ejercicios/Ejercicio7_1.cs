using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int numero = 1;
    // Start is called before the first frame update
    void Start()
    {
        while (numero > 100)// Bucle (Ciclo)
        {
            Debug.Log("7.1 || " + numero);
            numero++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
