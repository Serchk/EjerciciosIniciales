using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apuntes : MonoBehaviour
{
    // Variables GLOBALES
    int numeroA;
    int numeroB;

    // Start is called before the first frame update
    void Start()
    {
        // mantener control + clic izq para ir al m�todo
        int compraEnCasa = IrAlSuper(numeroA, numeroB); // puedes llamar variables globales para representar las locales del m�todo
        Debug.Log(compraEnCasa);
        Debug.Log(IrAlSuper(numeroA, numeroB));// no hay por qu� crear nueva variable en este caso

        //Estructuras de control if, for...

        //if() //condici�n entre parentesis
        {

        }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int IrAlSuper(int paga1, int paga2) // escribir el dato entre parentesis y llamar al valor en donde llames al m�todo
    {
        // Variables LOCALES
        //int paga1 = 3;
        //int paga2 = 5;
        int compra = paga1 + paga2;
        return compra;
    }
}
