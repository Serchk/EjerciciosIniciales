using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    float oroRecogido = 7f, oroTotal, horas = 4f, segundosEnUnaHora = 3600f;
    // Start is called before the first frame update
    void Start()
    {
        float segundos4Horas = segundosEnUnaHora * horas;
        oroTotal = oroRecogido * segundos4Horas;
        Debug.Log("Oro total: " + oroTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
