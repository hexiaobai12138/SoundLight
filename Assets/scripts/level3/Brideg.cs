using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brideg : MonoBehaviour
{
    public GameObject Button;
    public GameObject Character;
    public Vector3 toposition;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Button.SetActive(true);

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Button.SetActive(false);
    }

    private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            Character.transform.position=toposition;
        }
    }
}
