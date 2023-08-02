using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validateBypass : MonoBehaviour
{
    varHandler handler;

    public int i_field;
    public int j_field;
    public int k_field;
    public bool flag_field;

    public AudioSource errorAudio;
    public AudioSource successAudio;

    void Start()
    {
        handler = GameObject.Find("Player").GetComponent<varHandler>();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.gameObject.name == "Sphere")
        {
            Debug.Log(validateFields());
            if (validateFields())
            {
                Destroy(gameObject);
                
            }
            else
            {
                //play err noise
                errorAudio.Play();  
            }
        }
    }

    bool validateFields()
    {
        return (handler.getI() == i_field && handler.getJ() == j_field &&
            handler.getK() == k_field && handler.getFlag() == flag_field);
    }
}
