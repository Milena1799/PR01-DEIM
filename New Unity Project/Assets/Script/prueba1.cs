using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba1 : MonoBehaviour
{

    public string texto = "Holi";
    public int numeroEntero = 345;
    public int numeroEnteroDos = 3;
    float numeroDecimal = 55.3f;
    public int resultado; 
    bool boleana = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(texto);
        resultado = numeroEntero * numeroEnteroDos;
        Debug.Log(resultado);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
