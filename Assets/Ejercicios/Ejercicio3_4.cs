using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] float EXP;
    float LVL;
    // Start is called before the first frame update
    void Start()
    {
        LVL = 32 + (9 * EXP / 5);
        Debug.Log("3.4 || LVL: " + LVL);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
