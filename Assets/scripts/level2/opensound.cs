using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opensound : MonoBehaviour
{
    public GameObject sound;
    private void OnTriggerEnter2D(Collider2D other)
    {
        sound.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameObject.SetActive(false);
    }
}
