using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkButton2 : MonoBehaviour
{
   public GameObject Button;
    public GameObject talkUI;
    public GameObject levelcontroller;
    public int Novelcount=0;


    private DialogSystem dialogSystem;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (levelcontroller.GetComponent<Level1Controll>().noveling == Novelcount)
        {
            Button.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Button.SetActive(false);
    }

    private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            dialogSystem=talkUI.GetComponent<DialogSystem>();
            dialogSystem.novelcnt=Novelcount;
            Button.SetActive(false);
            talkUI.SetActive(true);
            levelcontroller.GetComponent<Level1Controll>().noveling++;
        }
    }
}
