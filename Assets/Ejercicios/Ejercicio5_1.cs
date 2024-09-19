using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    [SerializeField] int vida1;
    [SerializeField] int vida2;
    // Start is called before the first frame update
    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("5.1 || Ambos personajes tienen la misma vida.");
        }
        else
        {
            Debug.Log("5.1 || No tienen la misma vida.");
        }
    }

    
}
