using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // no lo consigo :/
    float cantidad = 100;
    string moneda = "euro";
    // Start is called before the first frame update
    void Start()
    {
        string conversion = Convertir(cantidad, moneda);
        Debug.Log(conversion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    string Convertir(float cantidad, string moneda)
    {
        if(moneda == "euro")
        {
            float convertirADolar = cantidad * 1.1117866f;
            string conversion = cantidad + " euros son " + convertirADolar + " dolares.";
            return conversion;
        }
        else 
        { 
            float convertirAEuro = cantidad * 0.90009557f;
            string conversion = cantidad + "dolares son " + convertirAEuro + " euros.";
            return conversion;
        }
    }
}
