using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class corrutine : MonoBehaviour
{
    [SerializeField] Text MyText;
  

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cronometro");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Cronometro()
    {
        for (int hora = 0; hora <= 59; hora++)
        {
            yield return new WaitForSeconds(3600f);

            for (int minuto = 0; minuto <= 59; minuto++)
            {
                yield return new WaitForSeconds(60f);

                for (int segundo = 0; segundo <= 59; segundo++)
                {
                    yield return new WaitForSeconds(1f);
                   
                    MyText.text = "Hora :" + hora + minuto + segundo;



                }
            }

            print(MyText.text);

        }

    }
}
