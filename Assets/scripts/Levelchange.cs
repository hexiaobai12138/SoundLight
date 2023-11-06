using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelchange : MonoBehaviour
{
    public GameObject Button;
    public GameObject levelcontroller;
    public int Novelcount = 0;
    public string Scenename = "";
    public bool ending=false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (levelcontroller.GetComponent<Level1Controll>().noveling == Novelcount)
        {
            Button.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Button.SetActive(false);
    }

    private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            Button.SetActive(false);
            UILevel.Levels[levelcontroller.GetComponent<Level1Controll>().Levelcnt] = true;
            SceneManager.LoadScene(Scenename);
        }
    }
}
