using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peiyin1_1 : MonoBehaviour
{
    public GameObject Panel;
    private BGMcontroll bgmcontroll;
    private DialogSystem dialogsystem;
    //private AudioSource audioSource;
    private int soundcnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        bgmcontroll = GetComponent<BGMcontroll>();
        dialogsystem = Panel.GetComponent<DialogSystem>();
        //audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogsystem.novelcnt == 0)
        {
            if (dialogsystem.index == 2&&soundcnt==0)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if(dialogsystem.index == 4&&soundcnt==1)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if(dialogsystem.index == 10 && soundcnt == 2)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }
        else if(dialogsystem.novelcnt == 1)
        {
            if (dialogsystem.index == 2 && soundcnt == 3)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 4 && soundcnt == 4)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 6 && soundcnt == 5)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 8 && soundcnt == 6)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 10 && soundcnt == 7)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }
        else if (dialogsystem.novelcnt == 2)
        {
            if (dialogsystem.index == 6 && soundcnt == 8)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 8 && soundcnt == 9)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 10 && soundcnt == 10)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }
        else if (dialogsystem.novelcnt == 3)
        {
            if (dialogsystem.index == 2 && soundcnt == 11)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 4 && soundcnt == 12)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 6 && soundcnt == 13)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 8 && soundcnt == 14)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 10 && soundcnt == 15)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 16 && soundcnt == 16)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 18 && soundcnt == 17)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }

    }
}
