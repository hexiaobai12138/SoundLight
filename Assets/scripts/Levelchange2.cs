using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Levelchange2 : MonoBehaviour
{
    public GameObject levelcontroller;
    public int Novelcount = 0;
    public string Scenename = "";

    private DialogSystem dialogSystem;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (levelcontroller.GetComponent<Level1Controll>().noveling == Novelcount)
        {
            SceneManager.LoadScene(Scenename);
        }
    }
}
