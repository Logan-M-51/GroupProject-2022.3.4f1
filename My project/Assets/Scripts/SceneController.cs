using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject bugPrefab;
    private GameObject[] bugs;
    private const int MAX_BUG_COUNT = 10;
    private int numBugs;

    // Start is called before the first frame update
    void Start()
    {
        bugs = new GameObject[MAX_BUG_COUNT];
        bugs[0] = Instantiate(bugPrefab) as GameObject;
        bugs[0].transform.position = new Vector3(40, 0, 15);
        float angle = Random.Range(0, 360);
        bugs[0].transform.Rotate(0, angle, 0);
        numBugs = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void AddBug ()
    {
        if (numBugs < MAX_BUG_COUNT)
        {
            bugs[numBugs] = Instantiate(bugPrefab) as GameObject;
            bugs[numBugs].transform.position = new Vector3(40, 0, 15);
            float angle = Random.Range(0, 360);
            bugs[numBugs].transform.Rotate(0, angle, 0);
            numBugs += 1;
        }
    }
}
