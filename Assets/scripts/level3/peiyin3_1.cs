using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peiyin3_1 : MonoBehaviour
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
        }

    }
}
