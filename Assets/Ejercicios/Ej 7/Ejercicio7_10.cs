using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        // comprobar par o impar
        if (numero1 %2 == 0) 
        {
            Debug.Log("7.10 || Número 1 es par.");
        }
        else
        {
            Debug.Log("7.10 || Número 1 es impar.");
        }
        if (numero2 %2 == 0) 
        {
            Debug.Log("7.10 || Número 2 es par.");
        }
        else
        {
            Debug.Log("7.10 || Número 2 es impar.");
        }

        //comprobar negativo o positivo
        if (numero1 < 0) 
        {
            Debug.Log("7.10 || Número 1 es negativo.");
        }
        else
        {
            Debug.Log("7.10 || Número 1 es positivo.");
        }
        if (numero2 < 0) 
        {
            Debug.Log("7.10 || Número 2 es negativo.");
        }
        else
        {
            Debug.Log("7.10 || Número 2 es positivo.");
        }


        if (numero1 < numero2)
        {
            Debug.Log("7.10 || Número 1: " + numero1 + " || Número 2: " + numero2);
            for (int i = numero1; i <= numero2; i++)
            {
                Debug.Log("7.10 || " + i);
            }
        }
        else
        {
            Debug.Log("7.10 || Número 1: " + numero1 + " || Número 2: " + numero2);
            for (int i = numero2; i <= numero1; i++)
            {
                Debug.Log("7.10 || " + i);
            }
        }
    }
}
