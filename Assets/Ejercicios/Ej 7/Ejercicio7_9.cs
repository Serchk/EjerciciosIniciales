using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int num;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("7.9 || N�meros multiplos de 3 entre 1 y " + num);
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0)
            {
                Debug.Log("7.9 || " + i);
            }

        }
    }

}
