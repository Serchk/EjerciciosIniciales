using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje pepe;
    [SerializeField] Personaje pepa;
    bool prepararPersonaje = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       
        if (prepararPersonaje == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PrepararPersonajes();
                Debug.Log(pepe.Nombre + " tine " + pepe.Vida + " de vida.");
                Debug.Log(pepa.Nombre + " tine " + pepa.Vida + " de vida.");
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Ya ejecutado");
            }
        }
    }

    void PrepararPersonajes()
    {
        pepe.Vida = 10;
        pepa.Vida = 20;
        pepe.Nombre = "Pepe";
        pepa.Nombre = "Pepa";

        prepararPersonaje = false;

    }
}
