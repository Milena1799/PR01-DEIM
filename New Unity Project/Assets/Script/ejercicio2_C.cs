using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2_C : MonoBehaviour
{
    int num2; 
    // Start is called before the first frame update
    void Start()
    {
        num2 = 1;
        while (num2 <= 10)
        {
            if (num2 <5)
            {
                print("El numero es menor que 5");
            }
            else if (num2 >= 5 && num2 <=10)
            {
                print("El numero es " + num2);
            }
            else
            {
                print("El numero es 10");
            }

            num2++;
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
