using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 10;
    float exp = 20;
    char carac = 'R';
    float resultadoSuma, resultadoResta;
    // Start is called before the first frame update
    void Start()
    {
        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log(resultadoSuma + resultadoResta);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
