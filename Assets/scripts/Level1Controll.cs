using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Controll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject talkUI;
    public int Novelcount = 0;
    public int noveling = 0;
    public int maxnovelcount = 999;
    public bool novelbegin = false;


    private DialogSystem dialogSystem;
    private void Awake()
    {
        if(novelbegin)
        {
            dialogSystem = talkUI.GetComponent<DialogSystem>();
            dialogSystem.novelcnt = Novelcount;
            talkUI.SetActive(true);
            noveling++;
        }
    }

    
}
