using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outsubway : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 direction;
    public Rigidbody2D rbody;
    // Start is called before the first frame update
    private const float changetime = 25f;
    public float changetimer;
    public bool RorL;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        direction = Vector2.down;
        changetimer = changetime;
    }

    // Update is called once per frame
    void Update()
    {
        changetimer -= Time.deltaTime;
        Vector2 position = rbody.position;
        if(changetimer<6f)
        {
             position.x += direction.x * speed * Time.deltaTime;
             position.y += direction.y * speed * Time.deltaTime;
        }
       
        if(changetimer<4.2f)
        {
            if (RorL)
            {
                direction = Vector2.left;
            }
            else
            {
                direction = Vector2.right;
            }
        }
        if(changetimer < 0f)
        {
            gameObject.SetActive(false);
        }
        rbody.position = position;
    }
}
