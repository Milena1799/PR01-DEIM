using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba1 : MonoBehaviour
{

    public string texto = "Holi";
    public string texto1 = "Tus decimales son ";
    public int numeroEntero = 345;
    public int numeroEnteroDos = 3;
    float numeroDecimal = 55.3f;
    private int resultado; 
    string cadena;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(texto);
        resultado = numeroEntero * numeroEnteroDos;
        Debug.Log(resultado);

        cadena = texto1 + numeroDecimal;
        Debug.Log(cadena);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
