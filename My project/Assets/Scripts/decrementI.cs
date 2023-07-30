using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decrementI : MonoBehaviour
{
    varHandler handler;

    void Start()
    {
        handler = GameObject.Find("Player").GetComponent<varHandler>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision detected");
        if (other.gameObject.name == "Sphere")
        {
            handler.decrementI();
        }
    }
}
