using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba2_D : MonoBehaviour
{
    public int aleatorio;
    
    // Start is called before the first frame update
    void Start()
    {
        int fail = 0;
        while (aleatorio != 5)
        {
            aleatorio = Random.Range(0, 10);
            if (aleatorio == 5)
            {
                print("Este es tu número aleatorio" + aleatorio);
                print("Este es tu número de fallos " + fail);
            }
            else
            {
                fail++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
