using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class corrutina : MonoBehaviour
{
    [SerializeField] Text MyText;
    int segundos;
    int minutos;
    int horas;
    string textoFinal;

    // Start is called before the first frame update
    void Start()
    {
        segundos = 0;
        minutos = 0;
        horas = 0;
        StartCoroutine("clockStart");
        
            
    }

    IEnumerator clockStart()
    {
        for (; ; segundos++)
        {
            if (segundos > 59)
            {
                minutos++;
                segundos = 0;
            }

            string segundosST = segundos.ToString("D2");

            if (minutos > 59)
            {
                horas++;
                minutos = 0;

            }

            string minutesST = minutos.ToString("D2");
            string horasST = horas.ToString();

            textoFinal = horasST + ":" + minutesST + ":" + segundosST;
            print(textoFinal);
            MyText.text = textoFinal;
            yield return new WaitForSeconds(1f);

        }





    }

    }
