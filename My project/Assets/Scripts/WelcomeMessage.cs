using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WelcomeMessage : MonoBehaviour
{
    [SerializeField] TMP_Text welcomeScreen;
    int currentMsg;
    int numMsg;
    string[] messages;

    private GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        setMessages();
        
        welcomeScreen.text = messages[0];
        currentMsg = 0;
    }

    void setMessages()
    {
        screen = GameObject.Find("Welcome Screen");
        numMsg = 2;
        messages = new string[numMsg];

        messages[0] = "Welcome, new recruit!";
        messages[1] = "You are tasked with the job of executing the code in front of you.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnPointerDown()
    {
        Debug.Log("on pointer down");
        NextMessage();
    }

    public void NextMessage()
    {
        Debug.Log("here");
        if (currentMsg == numMsg - 1)
        {
            //at last message
            screen.SetActive(false);
        } else
        {
            currentMsg++;
            welcomeScreen.text = messages[currentMsg];
        }

    }
}
