using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamelogic1 : MonoBehaviour
{
    public GameObject nowfalse;
    public GameObject nowtrue;
    // Start is called before the first frame update
    private void OnTriggerExit2D(Collider2D other)
    {
        nowtrue.SetActive(true);
        nowfalse.SetActive(false);
    }


}
