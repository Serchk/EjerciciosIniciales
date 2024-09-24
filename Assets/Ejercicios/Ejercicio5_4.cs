using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] float dividendo, divisor;

    // Start is called before the first frame update
    void Start()
    {
        if (divisor == 0)
        {
            Debug.Log("5.4 || No puedes divivdir entre 0");
        }
        else
        {
            float resultado = dividendo / divisor;
            Debug.Log("5.4 || " + dividendo + " / " + divisor + " = " + resultado);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
