using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DioalogBGM1_2 : MonoBehaviour
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


        if (Panel.activeSelf&&!audioSource.isPlaying)
        {

            if (dialogsystem.novelcnt == 0)
            {
                bgmcontroll.PlayMusic(0);
            }
            else if (dialogsystem.novelcnt == 1)
            {
                //bgmcontroll.UnPauseMusic();
                bgmcontroll.FadeIn(1);
            }
            
        }
        else if (!Panel.activeSelf && audioSource.isPlaying)
        {
            bgmcontroll.FadeOut(1);
            //bgmcontroll.PauseMusic();
        }
    }
}
