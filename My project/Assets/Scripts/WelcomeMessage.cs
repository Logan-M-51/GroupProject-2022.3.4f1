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
        numMsg = 10;
        messages = new string[numMsg];

        messages[0] = "Welcome, new recruit!\n (Tap to continue.)";
        messages[1] = "You are tasked with the job of executing the code in front of you (look down).";
        messages[2] = "I, J, and K are variables used to keep count. You can always see their values " +
            "in the upper left corner.";
        messages[3] = "The flag is also a variable. It can be true or false.";
        messages[4] = "You are responsible for setting the values of the variables according to the code provided.";
        messages[5] = "The '++' will increase a counter (so I++ will increase the count of I) and the '--' will " +
            "decrease the counter.";
        messages[6] = "Tap to fire an electroshock projectile to change the values of the counters or to toggle the " +
            "flag between true and false";
        messages[7] = "When you have executed the code, fire a projectile at the exit to move on to the next code.";
        messages[8] = "However, if you have not executed the code correctly, a bug will be introduced into the program " +
            "and you will not be able to leave until you have set the variables to the correct values";
        messages[9] = "Please try to keep the number of bugs in the program to a minimum...";
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
