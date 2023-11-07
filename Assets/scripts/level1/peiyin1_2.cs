using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peiyin1_2 : MonoBehaviour
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
            if (dialogsystem.index == 6&&soundcnt==0)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if(dialogsystem.index == 8&&soundcnt==1)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if(dialogsystem.index == 10 && soundcnt == 2)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 12 && soundcnt == 3)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 16 && soundcnt == 4)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 18 && soundcnt == 5)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }
        else if(dialogsystem.novelcnt == 1)
        {
            if (dialogsystem.index == 2 && soundcnt == 6)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 4 && soundcnt == 7)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
            else if (dialogsystem.index == 6 && soundcnt == 8)
            {
                bgmcontroll.PlayMusic(soundcnt++);
            }
        }

    }
}
