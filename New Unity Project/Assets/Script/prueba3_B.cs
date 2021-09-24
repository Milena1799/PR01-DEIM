using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba3_B : MonoBehaviour
{
    private int var;
  
    

    // Start is called before the first frame update
    void Start()
    {
        var = multiplicar(64, 4);
        print(var);
        if (Par(var) == true)
        {
            print("Es par");
        }
        else
        {
            print("ES impar");
        }
    }


    int multiplicar (int num1, int num2)
    {
        int resultado = num1 * num2;
            return resultado;

    }

    // Update is called once per frame
    void Update()
    {


    }

    bool Par(int numero)
    {
        bool NumeroPar;
        if (numero % 2 == 0)
        {
            NumeroPar = true;
        }
        else
        {
            NumeroPar = false;

        }

        return NumeroPar;
    }
}
