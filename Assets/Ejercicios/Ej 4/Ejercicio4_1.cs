using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    float radio = 3, PI = 3.14f;
    float baseTriangulo = 4, alturaTriangulo = 8;
    int lado1 =3, lado2 =3;
    float areaCirculo, areaTriangulo;
    float areaCuadrado;
    // Start is called before the first frame update
    void Start()
    {
        areaCirculo = radio * radio * PI;
        areaTriangulo = baseTriangulo * alturaTriangulo / 2;
        areaCuadrado = lado1 * lado2;
        Debug.Log("4.1 || Áreas || Círculo: " + areaCirculo + " || Triángulo: " + areaTriangulo + " || Cuadrado: " + areaCuadrado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
