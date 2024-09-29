using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
       
        if (numero1 < numero2)
        {
            Debug.Log("7.8 || Números pares entre " + numero1 + " y " + numero2);
            for (int i = numero1; i <= numero2; i++)
            {
                if(i %2 == 0)
                {
                    Debug.Log("7.8 || " + i);
                }
                
            }
        }
        else
        {
            Debug.Log("7.8 || Números pares entre " + numero2 + " y " + numero1);
            for (int i = numero2; i <= numero1; i++)
            {
                if (i % 2 == 0)
                {
                    Debug.Log("7.8 || " + i);
                }
            }
        }
    }
}
