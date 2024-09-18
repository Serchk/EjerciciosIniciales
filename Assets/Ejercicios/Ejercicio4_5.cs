using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    float radio = 3, PI = 3.14f;
    float baseTriangulo = 4, alturaTriangulo = 8;
    int lado1 = 3, lado2 = 3;
    float areaCirculo, areaTriangulo;
    float areaCuadrado;
    // Start is called before the first frame update
    void Start()
    {
        areaCirculo = radio * radio * PI;
        areaTriangulo = baseTriangulo * alturaTriangulo / 2;
        areaCuadrado = lado1 * lado2;
        string conversion = Convertir(areaCuadrado, "euro");
        Debug.Log(conversion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string Convertir(float cantidad, string moneda)
    {
        if (moneda == "euro")
        {
            float convertirADolar = cantidad * 1.1117866f;
            string conversion = "4.3 || " + cantidad + " euros son " + convertirADolar + " dolares.";
            return conversion;
        }
        else if (moneda == "dolares")
        {
            float convertirAEuro = cantidad * 0.90009557f;
            string conversion = "4.3 || " + cantidad + "dolares son " + convertirAEuro + " euros.";
            return conversion;
        }
        else
        {
            string conversion = "4.3 || Indica la moneda para poder hacer la conversión(euro o dolar)";
            return conversion;
        }
    }
}
