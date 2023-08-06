using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTo : MonoBehaviour
{
    public Transform teleportationLocation;
    private GameObject[] player_objs;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.gameObject.name == "Sphere")
        {
            teleport();
        }
    }

    void teleport()
    {
        player_objs = GameObject.FindGameObjectsWithTag("player");
        foreach (GameObject obj in player_objs)
        {
            float pos_x = teleportationLocation.position.x;
            float pos_z = teleportationLocation.position.z;
            obj.transform.position = new Vector3(pos_x, obj.transform.position.y, pos_z);
        }
        
    }
}
