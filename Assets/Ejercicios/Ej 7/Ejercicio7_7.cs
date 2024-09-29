using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejecicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
        if (numero1 < numero2)
        {
            Debug.Log("7.7 || Número 1: " + numero1 + " || Número 2: " + numero2 );
            for (int i = numero1; i <= numero2; i++)
            {
                Debug.Log("7.7 || " + i);
            }
        }
        else
        {
            Debug.Log("7.7 || Número 1: " + numero1 + " || Número 2: " + numero2 );
            for (int i = numero2; i <= numero1; i++)
            {
                Debug.Log("7.7 || " + i);
            }
        }
    }

   
}
