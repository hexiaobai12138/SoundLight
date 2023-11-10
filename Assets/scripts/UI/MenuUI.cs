using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.TextCore.Text;
using System;

public class MenuUI : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    [SerializeField]
    private GameObject MenuPanel;

    public void SetMenuPanelActive(bool state)
    {
        MenuPanel.SetActive(state);
    }

    //暂停
    public static void Pause()
    {
        Time.timeScale = 0;
    }

    //继续
    public static void Continue()
    {
        Time.timeScale = 1;
    }


    //Tip按钮按下
    public void TipButtonClick() {

        if(!Panel1.activeSelf&&!Panel2.activeSelf)
        {
            Panel2.SetActive(true);
        }


        //其他事件
    }

}

