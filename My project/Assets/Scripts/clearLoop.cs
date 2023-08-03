using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearLoop : MonoBehaviour
{

    public string tag;

    public void clear()
    {
        GameObject[] loop_objects = GameObject.FindGameObjectsWithTag(tag);
        foreach (GameObject target in loop_objects)
        {
            Destroy(target);
        }
    }
}
