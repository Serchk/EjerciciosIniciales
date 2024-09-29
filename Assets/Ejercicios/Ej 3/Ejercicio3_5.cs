using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] int radio;
    float longitud, area;
    float PI = 3.14f;
    // Start is called before the first frame update
    void Start()
    {
        longitud = 2 * PI * radio;
        area = PI * radio * radio;

        Debug.Log("3.5 || Longitud: " +  longitud + " || Área: " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
