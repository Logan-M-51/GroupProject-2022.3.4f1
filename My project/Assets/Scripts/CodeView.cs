using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeView : MonoBehaviour
{
    // code visible (top, middle, bottom)
    public int level = 0;
    public GameObject top;
    public GameObject middle;
    public GameObject bottom;

    // Start is called before the first frame update
    void Start()
    {
        TopView();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeView ()
    {
        switch (level)
        {
            case 0:
                MiddleView();
                break;
            case 1:
                BottomView();
                break;
            case 2:
                TopView();
                break;
        }
    }

    private void TopView()
    {
        level = 0;
        top.SetActive(true);
        middle.SetActive(false);
        bottom.SetActive(false);
    }

    private void MiddleView()
    {
        level = 1;
        top.SetActive(false);
        middle.SetActive(true);
        bottom.SetActive(false);
    }

    private void BottomView()
    {
        level = 2;
        top.SetActive(false);
        middle.SetActive(false);
        bottom.SetActive(true);
    }
}
