using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peiyin3_3 : MonoBehaviour
{
    private BGMcontroll bgmcontroll;
    public GameObject Levelcontroll;
    private AudioSource audioSource;
    private int soundcnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        bgmcontroll = GetComponent<BGMcontroll>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!audioSource.isPlaying)
        {
            if (Levelcontroll.GetComponent<Level1Controll>().noveling==0|| Levelcontroll.GetComponent<Level1Controll>().noveling == 1)
            {
                bgmcontroll.PlayMusic(0);
            }
            else
            {
                bgmcontroll.PlayMusic(1);
            }
        }


    }
}
