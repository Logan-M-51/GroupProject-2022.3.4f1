using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject bugPrefab;
    private GameObject[] bugs;
    private int MAX_BUG_COUNT;
    private int numBugs;
    public TextMeshProUGUI bug_text;

    // Start is called before the first frame update
    void Start()
    {
        MAX_BUG_COUNT = 10;
        bugs = new GameObject[MAX_BUG_COUNT];
        bugs[0] = Instantiate(bugPrefab) as GameObject;
        bugs[0].transform.position = new Vector3(40, 0, 15);
        float angle = Random.Range(0, 360);
        bugs[0].transform.Rotate(0, angle, 0);
        numBugs = 1;
        bug_text.text = numBugs.ToString();
    }

    public void AddBug()
    {
        if (numBugs == MAX_BUG_COUNT)
        {
            int newCount = 2 * MAX_BUG_COUNT;
            GameObject[] newBugs = new GameObject[newCount];

            for (int i = 0; i < MAX_BUG_COUNT; i++)
            {
                newBugs[i] = bugs[i];
            }

            bugs = newBugs;
            MAX_BUG_COUNT = newCount;

        }

        bugs[numBugs] = Instantiate(bugPrefab) as GameObject;
        bugs[numBugs].transform.position = new Vector3(40, 0, 15);
        float angle = Random.Range(0, 360);
        bugs[numBugs].transform.Rotate(0, angle, 0);
        numBugs += 1;
        bug_text.text = numBugs.ToString();
    }
}
