using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba2 : MonoBehaviour
{
    int numero = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numero <= 11) 
        {
            numero++;
           
            

        }
       
        else 
        {
            Debug.Log("Ha llegado al limite");
        }
        
    }
}
