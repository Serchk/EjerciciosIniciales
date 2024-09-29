using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H, M, S;

    // Start is called before the first frame update
    void Start()
    {
        if (H >= 0 && H <= 24)
        {
            
            if (M >= 0 && M <= 60)
            {
                if(S >= 0 && S <= 60)
                {
                    Debug.Log("Son las " + H + ":" + M + ":" + S);
                }
                else
                {
                    Debug.Log("Escriba un segundo válido");
                }
            } 
            else
            {
                Debug.Log("Escriba un minuto válido");
            }
        }
        else
        {
            Debug.Log("Escriba una hora válida");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
