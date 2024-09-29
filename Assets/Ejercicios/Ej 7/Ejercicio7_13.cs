using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numero;
    
    // Start is called before the first frame update
    void Start()
    {
        bool resultado = PruebaNumeroPrimo(numero);
        if (resultado = true)
        {
            Debug.Log("El numero es primo");
        }
        else
        {
            Debug.Log("El numero no es primo");
        }
    }

    // Update is called once per frame
    bool PruebaNumeroPrimo(int numero) 
    {
        bool primo;
        if (numero / 1 == numero && numero / numero == 1)
        {
            primo = true;
        }
        else
        {
            primo = false;
        }
        return primo;
    }
}
