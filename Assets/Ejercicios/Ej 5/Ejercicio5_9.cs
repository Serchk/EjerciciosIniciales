using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    // Start is called before the first frame update
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("El enemigo hace 350 puntos de daño y tiene 650 de vida");
        }
        else if (tipo == 2)
        {
            Debug.Log("El enemigo hace 300 puntos de daño y tiene 550 de vida");

        }
        else if (tipo == 3) 
        {
            Debug.Log("El enemigo hace 300 puntos de daño y tiene 500 de vida");
        }
        else if (tipo == 4) 
        { 
            Debug.Log("El enemigo hace 310 puntos de daño y tiene 460 de vida");
        }
        else if (tipo == 5)
        { 
            Debug.Log("El enemigo hace 280 puntos de daño y tiene 490 de vida");
        }
        else if(tipo == 6) 
        {
            Debug.Log("El enemigo hace 360 puntos de daño y tiene 520 de vida");
        }
        else
        {
            Debug.Log("Elige un tipo de enemigo del 1 al 6");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
