using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closesomething : MonoBehaviour
{
    public GameObject levelcontroller;
    public List<GameObject> Toclose;
    public List<int> Novelcount;
    public bool TorF=false;
    private int novelingnow;
    int thingscnt = 0;
    // Update is called once per frame
    void Update()
    {
        novelingnow = levelcontroller.GetComponent<Level1Controll>().noveling;
        for(thingscnt=0;thingscnt<Novelcount.Count;thingscnt++)
        {
             if (novelingnow == Novelcount[thingscnt])
            {
                Toclose[thingscnt].SetActive(TorF);
            }
        }
        
    }
}
