using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamelogic2 : MonoBehaviour
{
    public GameObject Button;
    public GameObject nextbutton;

    // Update is called once per frame
    void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            nextbutton.SetActive(true);
            Button.SetActive(false);
        }
    }
}
