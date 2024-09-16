using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKmH;
    float velocidadMS, conversion = 3.6f; //dividiendo los KmH entre 3.6 obtenemos los ms
    // Start is called before the first frame update
    void Start()
    {
        velocidadMS = velocidadKmH / conversion;
        Debug.Log("3.6 || Velocidad en ms: " +  velocidadMS); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
