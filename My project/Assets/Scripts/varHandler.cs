using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class varHandler : MonoBehaviour
{
    public bool player_flag;
    public int player_i;
    public int player_j;
    public int player_k;
    void Start()
    {
        player_flag = false;
        player_i = 0;
        player_j = 0;
        player_k = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(player_flag);
    }

    public void toggleFlag()
    {
        player_flag = !player_flag;
    }
}
