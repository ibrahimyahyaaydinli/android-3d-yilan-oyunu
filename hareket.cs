using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class hareket : MonoBehaviour
{
    public GameObject kuyruk;

    List<GameObject> kuyruklar;
    Vector3 eski_pozisyon;
    GameObject cikarilan_kuyruk;
    public float hiz = 15.0f;

    public float donme = 300f;


    private void OnTriggerEnter(Collider nesne)
    {
        if (nesne.gameObject.tag == "yem")
        {
            GameObject yeni_kuyruk = Instantiate(kuyruk, eski_pozisyon, Quaternion.identity);
            kuyruklar.Add(yeni_kuyruk);
        }
          if (nesne.gameObject.tag == "kuyruk" || nesne.gameObject.tag == "duvar")
        {
            SceneManager.LoadScene("Scenes/SampleScene");
         }
    }

    void Start()
    {
        kuyruklar = new List<GameObject>();

        for (int i = 0; i <= 5; i++)
        {
            GameObject yeni_kuyruk = Instantiate(kuyruk, eski_pozisyon, Quaternion.identity);
            kuyruklar.Add(yeni_kuyruk);
        }
        InvokeRepeating("hareket_et", 0, 0.1f);
    }

    void hareket_et()
    {
        eski_pozisyon = transform.position;
        transform.Translate(0, 0, hiz * Time.deltaTime);

        if (kuyruklar.Count > 0)
        {
            kuyruklar[0].transform.position = eski_pozisyon;
            cikarilan_kuyruk = kuyruklar[0];
            kuyruklar.RemoveAt(0);
            kuyruklar.Add(cikarilan_kuyruk);

        }
    }

    void Update()
    {
        transform.Translate(Vector3.forward * hiz * Time.deltaTime);

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
