using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject bugPrefab;
    private GameObject bug;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bug == null)
        {
            bug = Instantiate(bugPrefab) as GameObject;
            bug.transform.position = new Vector3(40, 0, 15);
            float angle = Random.Range(0, 360);
            bug.transform.Rotate(0, angle, 0);
        }
        
    }
}
