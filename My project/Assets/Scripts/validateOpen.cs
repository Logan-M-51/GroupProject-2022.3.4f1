using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validateOpen : MonoBehaviour
{
    varHandler handler;

    public int i_field;
    public int j_field;
    public int k_field;
    public bool flag_field;

    public MeshRenderer mesh;
    public BoxCollider door_collider;

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
                door_collider.enabled = false;
                mesh.enabled = false;
            }
        }
    }

    bool validateFields()
    {
        return (handler.getI() == i_field && handler.getJ() == j_field &&
            handler.getK() == k_field && handler.getFlag() == flag_field);
    }
}
