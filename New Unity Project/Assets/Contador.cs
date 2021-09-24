using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    [SerializeField] Text MyText;
    bool encenderContador;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (encenderContador == false)
            {
                StartCoroutine("Contando");
                encenderContador = true;
            }
            else
            {
                StopCoroutine("Contando");
                encenderContador = false;
            }
        }
        
    }

    IEnumerator Contando()
    {
        for (int n = 0; n <= 100 ; n ++)
         {
            MyText.text = "Contando" + n;
            yield return new WaitForSeconds(1f);
         }

    }

   
}
