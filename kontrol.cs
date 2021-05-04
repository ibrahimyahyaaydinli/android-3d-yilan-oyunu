using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour
{
    public float hiz = 300f;
    public float donme = 300f;
    void Start()
    {




    }
    void Update()
    {
         if (Input.GetKey(KeyCode.W))
         {
        transform.Translate(Vector3.forward * hiz * Time.deltaTime);
         }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * hiz * Time.deltaTime);
         }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * -donme * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * donme * Time.deltaTime);
        }
    }
}
