using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApuntesWhile : MonoBehaviour
{
    [SerializeField] int vidas = 100;
    // Start is called before the first frame update
    void Start()
    {
        // While: MIENTRAS
        // Bucle indeterminado
        while (vidas > 0)// Bucle (Ciclo)
        {
            Debug.Log("Sigo vivo");
            vidas--;
        }
    }

}
 