using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero;
    // Start is called before the first frame update
    void Start()
    {
        if (numero > 0 && numero < 9)
        {
            Debug.Log("5.3 || El n�mero est� entre 0 y 9.");
        }
        else
        {
            Debug.Log("5.3 || Escribe un n�mero entre 0 y 9.");

        }
    }

    
}
