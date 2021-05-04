using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yem : MonoBehaviour
{

    int skor = 0;
    int atis_degeri = 100;

    void Start()
    {
        InvokeRepeating("kontrol", 0, 10.0f);

    }
    void kontrol()
    {
        float X = Random.Range(1300f, 1800f);
        float Z = Random.Range(485f, -150f);
        float Y = Random.Range(0.5f, 1.5f);

        Vector3 koordinat = new Vector3(X, 0, Z);
        transform.position = koordinat;

    }
    private void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "Player")
        {
            CancelInvoke();
            InvokeRepeating("kontrol", 0, 5.0f);
        }

        if (nesne.gameObject.tag == "kuyruk")
        {
            CancelInvoke();
            InvokeRepeating("kontrol", 0, 5.0f);
        }
    }
}
