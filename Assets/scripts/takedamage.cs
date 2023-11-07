using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takedamage : MonoBehaviour
{
    public GameObject Character;
    public GameObject Postprocessing;
    private float wuditime = 0f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Character.GetComponent<PlayerController>().hp>0&&wuditime==0)
        {
            Character.GetComponent<PlayerController>().hp -= 1;
            Postprocessing.GetComponent<postprocessing>().Takedamage();
            StartCoroutine(wudi());
        }
        if(Character.GetComponent<PlayerController>().hp <= 0)
        {

        }
    }
    private IEnumerator wudi()
    {
        wuditime = 1f;
        while(wuditime > 0f)
        {
            wuditime -= 0.05f;
            if (wuditime < 0f) wuditime = 0f;
            yield return new WaitForSeconds(0.1f);
        }
        yield break;
    }
}
