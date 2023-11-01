using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoNovel : MonoBehaviour
{

    public GameObject talkUI;
    public GameObject levelcontroller;
    public int Novelcount = 0;

    private DialogSystem dialogSystem;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (levelcontroller.GetComponent<Level1Controll>().noveling == Novelcount)
        {
            dialogSystem = talkUI.GetComponent<DialogSystem>();
            dialogSystem.novelcnt = Novelcount;
            talkUI.SetActive(true);
            levelcontroller.GetComponent<Level1Controll>().noveling++;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (levelcontroller.GetComponent<Level1Controll>().noveling == Novelcount+1)
        {
            gameObject.SetActive(false);
        }
    }


}
