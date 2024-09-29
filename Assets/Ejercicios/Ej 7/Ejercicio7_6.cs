using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int num;

    // Start is called before the first frame update
    void Start()
    {
        //con while
        int cuenta = num; 
        while (cuenta >= -num)
        {
            Debug.Log("7.6 || While: " + cuenta);
            cuenta--; 
        }

        //con for
        for (int i = num; i >= -num; i--)
        {
            Debug.Log("7.6 || For: " + i);
        }
    }

    
}
