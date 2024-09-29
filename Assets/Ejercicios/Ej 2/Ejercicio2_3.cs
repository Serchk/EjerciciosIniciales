using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 20, dobleDeVidas;
    float exp = 15f, tripleDeExp;
    float producto, cociente, resto;
    // Start is called before the first frame update
    void Start()
    {
       producto = vidas * exp;
       cociente = vidas / exp;
       resto = vidas % exp;
       dobleDeVidas = vidas * 2;
       tripleDeExp = exp * 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
