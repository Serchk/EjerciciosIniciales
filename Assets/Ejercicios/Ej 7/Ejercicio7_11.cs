using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int tablaMultiplicar;
    // Start is called before the first frame update
    void Start()
    {
        int limite = tablaMultiplicar * 10;
        for (int i = 1; i <= limite; i++)
        {
            if (i % tablaMultiplicar == 0)
            {
                Debug.Log("7.11 || " + i);
            }

        }
    }

}
