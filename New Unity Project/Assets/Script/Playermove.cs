using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    private Vector3 cubePos = new Vector3(0f, 0f, 0f);
    public float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        transform.position = cubePos;   

    }

    // Update is called once per frame
    void Update()
    {
        float desplH = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * desplH);
        float desp1V = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * Time.deltaTime * speed * desp1V);
        float desplZ = Input.GetAxis("Profundidad");
        transform.Translate(Vector3.back * Time.deltaTime * speed * desplZ);
        /*
        Vector3 destPos = new Vector3(-1f, 1f, 0f);
        cubePos = cubePos + destPos* Time.deltaTime * speed;
        transform.position = cubePos;
        */
    }
}
