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
    public TextMeshProUGUI i_text;
    public int player_j;
    public TextMeshProUGUI j_text;
    public int player_k;
    public TextMeshProUGUI k_text;
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
    }

    public void incrementI()
    {
        player_i++;
        updateI();
    }

    public void incrementJ()
    {
        player_j++;
        updateJ();
    }

    public void incrementK()
    {
        player_k++;
        updateK();
    }

    public void decrementI()
    {
        player_i--;
        updateI();
    }

    public void decrementJ()
    {
        player_j--;
        updateJ();
    }

    public void decrementK()
    {
        player_k--;
        updateK();
    }

    public void updateI()
    {
        i_text.text = player_i.ToString();
    }

    public void updateJ()
    {
        j_text.text = player_j.ToString();
    }

    public void updateK()
    {
        k_text.text = player_k.ToString();
    }

    public int getI()
    {
        return player_i; 
    }

    public int getJ()
    {
        return player_j;
    }

    public int getK()
    {
        return player_k;
    }

    public bool getFlag()
    {
        return player_flag;
    }
}
