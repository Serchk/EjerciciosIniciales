using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero;
    int doble = 2, triple = 3;
    // Start is called before the first frame update
    void Start()
    {
        doble *= numero;
        triple *= numero;
        Debug.Log("3.3 || Número: " + numero + "|| Doble: " +  doble + " || Triple: " + triple);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
