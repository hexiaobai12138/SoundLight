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


        if (Panel.activeSelf&&!audioSource.isPlaying)
        {

            if (dialogsystem.novelcnt == 0)
            {
                bgmcontroll.PlayMusic(0);
            }
            if (dialogsystem.novelcnt == 1)
            {
                bgmcontroll.PlayMusic(1);
            }
            
        }
        else if (!Panel.activeSelf)
        {
            bgmcontroll.FadeOut(1);
        }
    }
}
