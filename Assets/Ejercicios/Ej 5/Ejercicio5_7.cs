using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int numero1, numero2, numero3;
    // Start is called before the first frame update
    void Start()
    {
        //Primera posición
        if (numero1 > numero2 && numero1 > numero3)
        {
            Debug.Log("Número 1 ataca primero.");
        }
        else if (numero2 > numero3 && numero2 > numero1)
        {
            Debug.Log("Número 2 ataca primero.");
        }
        else
        {
            Debug.Log("Número 3 ataca primero.");
        }

        //Segunda posición
        if ((numero1 > numero2 && numero1 < numero3) || (numero1 < numero2 && numero1 > numero3))
        {
            Debug.Log("Número 1 ataca segundo.");
        }
        else if ((numero2 > numero1 && numero2 < numero3) || (numero2 < numero1 && numero2 > numero3))
        {
            Debug.Log("Número 2 ataca segundo.");
        }
        else
        {
            Debug.Log("Número 3 ataca segundo.");
        }

        //Tercera posición
        if (numero1 < numero2 && numero1 < numero3)
        {
            Debug.Log("Número 1 ataca último.");
        }
        else if (numero2 < numero3 && numero2 < numero1)
        {
            Debug.Log("Número 2 ataca último.");
        }
        else
        {
            Debug.Log("Número 3 ataca último.");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
