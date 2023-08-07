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

    public Transform teleportationLocation;

    private SceneController controller;

    void Start()
    {
        handler = GameObject.Find("Player").GetComponent<varHandler>();
        controller = GameObject.Find("Controller").GetComponent<SceneController>();
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
                teleport();
            }
            else
            {
                door_collider.enabled = true;
                mesh.enabled = true;
                controller.AddBug();
            }
        }
    }

    bool validateFields()
    {
        return (handler.getI() == i_field && handler.getJ() == j_field &&
            handler.getK() == k_field && handler.getFlag() == flag_field);
    }

    void teleport()
    {
        GameObject player = GameObject.Find("Mine_Cart");
        Debug.Log(player.transform.position);
        float pos_x = teleportationLocation.position.x;
        float pos_z = teleportationLocation.position.z;
        player.transform.position = new Vector3(pos_x, player.transform.position.y, pos_z);
        Debug.Log(player.transform.position);
    }
}
