using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int numero1, numero2, numero3;
    // Start is called before the first frame update
    void Start()
    {
        //Primera posici�n
        if (numero1 > numero2 && numero1 > numero3)
        {
            Debug.Log("N�mero 1 ataca primero.");
        }
        else if (numero2 > numero3 && numero2 > numero1)
        {
            Debug.Log("N�mero 2 ataca primero.");
        }
        else
        {
            Debug.Log("N�mero 3 ataca primero.");
        }

        //Segunda posici�n
        if ((numero1 > numero2 && numero1 < numero3) || (numero1 < numero2 && numero1 > numero3))
        {
            Debug.Log("N�mero 1 ataca segundo.");
        }
        else if ((numero2 > numero1 && numero2 < numero3) || (numero2 < numero1 && numero2 > numero3))
        {
            Debug.Log("N�mero 2 ataca segundo.");
        }
        else
        {
            Debug.Log("N�mero 3 ataca segundo.");
        }

        //Tercera posici�n
        if (numero1 < numero2 && numero1 < numero3)
        {
            Debug.Log("N�mero 1 ataca �ltimo.");
        }
        else if (numero2 < numero3 && numero2 < numero1)
        {
            Debug.Log("N�mero 2 ataca �ltimo.");
        }
        else
        {
            Debug.Log("N�mero 3 ataca �ltimo.");
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
