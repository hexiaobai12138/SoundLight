using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevel : MonoBehaviour
{
    public static List<bool> Levels= new List<bool> { true, false, false, false };
    public static int cntp=0;

    //private void Awake()
    //{
    //    PlayerPrefs.DeleteAll();
    //}
    private void Awake()
    {
        PlayerPrefs.SetInt("levels0", 1);
        if (PlayerPrefs.GetInt("levels0") == 1) Levels[0] = true;
        else Levels[0] = false;
        if (PlayerPrefs.GetInt("levels1") == 1) Levels[1] = true;
        else Levels[1] = false;
        if (PlayerPrefs.GetInt("levels2") == 1) Levels[2] = true;
        else Levels[2] = false;
        if (PlayerPrefs.GetInt("levels3") == 1) Levels[3] = true;
        else Levels[3] = false;
    }


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            cntp++;
        if(cntp==10) Levels[0]=Levels[1]=Levels[2]=Levels[3]=true;


        if (Levels[0] == true) PlayerPrefs.SetInt("levels0", 1);
        else PlayerPrefs.SetInt("levels0", 0);
        if (Levels[1] == true) PlayerPrefs.SetInt("levels1", 1);
        else PlayerPrefs.SetInt("levels1", 0);
        if (Levels[2] == true) PlayerPrefs.SetInt("levels2", 1);
        else PlayerPrefs.SetInt("levels2", 0);
        if (Levels[3] == true) PlayerPrefs.SetInt("levels3", 1);
        else PlayerPrefs.SetInt("levels3", 0);



    }
}



