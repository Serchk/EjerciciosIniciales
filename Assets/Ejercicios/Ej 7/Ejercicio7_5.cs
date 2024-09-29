using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int cuenta = 1;
    // Start is called before the first frame update
    void Start()
    {
        //con while
        while (cuenta <= numero)
        {
            Debug.Log("7.5 || While: " + cuenta);
            cuenta++;
        }

        //con for
        for (int i = 0; i <= numero; i++)
        {
            Debug.Log("7.5 || For: " + i);
        }
    }

   
}
