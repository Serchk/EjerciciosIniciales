using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int numero = 100;
    // Start is called before the first frame update
    void Start()
    {
        while (numero >= 1)// Bucle (Ciclo)
        {
            Debug.Log("7.3 || " + numero);
            numero--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
