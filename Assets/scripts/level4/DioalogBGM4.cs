using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioalogBGM4 : MonoBehaviour
{
    public GameObject Panel;
    private BGMcontroll bgmcontroll;
    private DialogSystem dialogsystem;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        bgmcontroll = GetComponent<BGMcontroll>();
        dialogsystem = Panel.GetComponent<DialogSystem>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Panel.activeSelf)
        {
            if (!audioSource.isPlaying)
            {
                if (dialogsystem.novelcnt == 0)
                {
                    bgmcontroll.PlayMusic(0);
                }
                else if (dialogsystem.novelcnt == 1)
                {
                    bgmcontroll.FadeIn(1);
                }
                else if (dialogsystem.novelcnt == 2)
                {
                    bgmcontroll.FadeIn(1);
                }
                else if (dialogsystem.novelcnt == 3 && dialogsystem.index < 16)
                {
                    bgmcontroll.FadeIn(1);
                }
                
            }
            else
            {
                if (dialogsystem.novelcnt == 3)
                {
                    if (dialogsystem.index >= 16)
                    {
                        bgmcontroll.FadeOut(1);
                    }
                }

            }
        }



        else if (!Panel.activeSelf)
        {
            bgmcontroll.FadeOut(1);

        }
    }
}
