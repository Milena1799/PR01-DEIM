using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Saludo("Marta", 21, "acuarios");
        Saludo("Sol", 18, "aries");
        Saludo("Cielo", 27, "leo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Saludo (string nombre, int edad, string signo)
    {
        print("Hola buenas " + nombre + ". Tu edad es " + edad + "años. Tu signo es " + signo);
    }
}
