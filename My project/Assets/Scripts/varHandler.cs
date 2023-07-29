using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class varHandler : MonoBehaviour
{
    public bool player_flag;
    public TextMeshProUGUI flag_text;
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
        //Debug.Log(player_flag);
    }

    public void toggleFlag()
    {
        player_flag = !player_flag;
        toggleFlagUI();
        
    }

    public void toggleFlagUI()
    {   
        if (player_flag)
        {
            flag_text.text = "true";
        }
        else
        {
            flag_text.text = "false";
        }
        Debug.Log(flag_text.text);
        //flag_text.ForceMeshUpdate(true);
    }

    public void incrementI()
    {
        player_i++;
    }

    public void incrementJ()
    {
        player_j++;
    }

    public void incrementK()
    {
        player_k++;
    }

    public void decrementI()
    {
        player_i--;
    }

    public void decrementJ()
    {
        player_j--;
    }

    public void decrementK()
    {
        player_k--;
    }
}
