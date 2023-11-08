using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
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
    public static void TipButtonClick() {
        Pause();
        //其他事件
    }
}

