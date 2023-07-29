using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automaticOpen : MonoBehaviour
{
    private bool isOpen;
    private MeshRenderer mesh;
    private BoxCollider door_collider;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        door_collider = GetComponent<BoxCollider>();
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        Transform doorTransform = gameObject.transform;
        Transform playerTransform = GameObject.Find("Player").transform;
        float delta = Vector3.Distance(doorTransform.position, playerTransform.position);

        //Debug.Log(delta);

        if (delta < 7.5f)
        {
            if (!isOpen)
            {
                door_collider.enabled = false;
                mesh.enabled = false;
                isOpen = true;
            }
        }
        else
        {
            if (isOpen)
            {
                door_collider.enabled = true;
                mesh.enabled = true;
                isOpen = false;
            }
        }

        
    }
}
