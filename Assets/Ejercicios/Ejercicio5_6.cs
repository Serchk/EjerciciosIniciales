using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int niveles;
    // Start is called before the first frame update
    void Start()
    {
        if (niveles == 0)
        {
            Debug.Log("5.6 || Charmander es nivel 0, le quedan 10 niveles para aprender un nuevo ataque.");
        }
        else if (niveles % 10 == 0)
        {
            Debug.Log("5.6 || Charmander subió 10 niveles, es nivel " + niveles + ", puede aprender un nuevo ataque.");
        }
        else
        {
            Debug.Log("5.6 || Charmander no puede aprender un nuevo ataque aún, le falta nivel.");
        }
        //ahora intentaba decir lo que le quedaba para llegar al siguiente nivel en el que puede subir de nivel. Pero no sale en el enunciado y no me puede entrtenar más jajaja.
        //else
        //{
        //    int nivelesParaNuevoAtaque = 10 - (niveles / 10);
        //    Debug.Log("5.6 || A Charmander es nivel " + niveles + ", le quedan " + nivelesParaNuevoAtaque + " niveles para aprender un nuevo ataque");
        //} 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
