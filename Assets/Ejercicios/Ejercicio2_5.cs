using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{

    int vidasPlayer1 = 30, vidasPlayer2 = 5, vidasPlayer3 = 20, vidasPlayer4 = 10;
    int vidasPlayer2º = 5; //segunda versión de vidasPlayer2 para poder hacer qie el 4 tome el valor del 2 y no el del 3 debido a que empeamos asignando al 2 el valor del 3.

    // Start is called before the first frame update
    void Start()
    {
        vidasPlayer2 = vidasPlayer3;
        Debug.Log(vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log(vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log(vidasPlayer1);
        vidasPlayer4 = vidasPlayer2º;
        Debug.Log(vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
