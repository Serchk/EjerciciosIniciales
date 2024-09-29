using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int vida1;
    [SerializeField] int vida2;

    // Start is called before the first frame update
    void Start()
    {
        if (vida1 < 3 && vida2 < 3)
        {
            Debug.Log("5.2 || Ambas vidas son menoresa 3.");
        }
    }

   
}
