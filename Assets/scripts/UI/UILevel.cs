using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevel : MonoBehaviour
{
    public static List<bool> Levels= new List<bool> { true, false, false, false };
    public static int cntp=0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
            cntp++;
        if(cntp==10) Levels[0]=Levels[1]=Levels[2]=Levels[3]=true;
    }
}



