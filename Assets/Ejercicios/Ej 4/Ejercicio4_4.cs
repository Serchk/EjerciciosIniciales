using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    float velocidadKmH = 110;
    float velocidadMS, conversion = 3.6f;
    // Start is called before the first frame update
    void Start()
    {
        ConversionKmHaMS();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ConversionKmHaMS()
    {
        velocidadMS = velocidadKmH / conversion;
        Debug.Log("4.4 || Velocidad en ms: " + velocidadMS);
    }
}
