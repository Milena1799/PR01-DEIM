using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba2_C : MonoBehaviour
{
    int numero = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        
        while(numero<= 20)
        {
            if (numero < 15)
            {
                Debug.Log("El número es menor que 15");
            }
            else if (numero >= 15 && numero <= 20)
            {
                Debug.Log("El número es " + numero);
            }
            else
            {
                Debug.Log("El número es 20");
            }

            numero++;
        }
      
         for (int num = 0; num < 10; num++)
        {
            Debug.Log("Hola este es el numero" + num);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
