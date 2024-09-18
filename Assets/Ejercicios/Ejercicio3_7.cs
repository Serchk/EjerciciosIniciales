using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float basee, altura;
    float area;
    // Start is called before the first frame update
    void Start()
    {
        area = basee * altura / 2;
        Debug.Log("3.7 || Área de visión del enemigo: " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
