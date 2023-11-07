using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peiyin2 : MonoBehaviour
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
            else if(dialogsystem.index == 32 && soundcnt == 2)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 36 && soundcnt == 3)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 38 && soundcnt == 4)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 40 && soundcnt == 5)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 44 && soundcnt == 6)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 48 && soundcnt == 7)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 50 && soundcnt == 8)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }
        else if(dialogsystem.novelcnt == 1)
        {
            if (dialogsystem.index == 4 && soundcnt == 9)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 6 && soundcnt == 10)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 8 && soundcnt == 11)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 10 && soundcnt == 12)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 12 && soundcnt == 13)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 14 && soundcnt == 14)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 16 && soundcnt == 15)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 18 && soundcnt == 16)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 20 && soundcnt == 17)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 22 && soundcnt == 18)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 24 && soundcnt == 19)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 26 && soundcnt == 20)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 28 && soundcnt == 21)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 32 && soundcnt == 22)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 34 && soundcnt == 23)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 40 && soundcnt == 24)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 42 && soundcnt == 25)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 56 && soundcnt == 26)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 58 && soundcnt == 27)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 60 && soundcnt == 28)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 62 && soundcnt == 29)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }
        else if (dialogsystem.novelcnt == 3)
        {
            if (dialogsystem.index == 2 && soundcnt == 30)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 4 && soundcnt == 31)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 6 && soundcnt == 32)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 8 && soundcnt == 33)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 10 && soundcnt == 34)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 12 && soundcnt == 35)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }
        else if (dialogsystem.novelcnt == 4)
        {
            if (dialogsystem.index == 2 && soundcnt == 36)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 4 && soundcnt == 37)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 6 && soundcnt == 38)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }

    }
}
