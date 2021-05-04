using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("as");
        
    }

  
    void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
