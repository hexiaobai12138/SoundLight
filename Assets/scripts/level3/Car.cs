using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Car : MonoBehaviour
{
    public float speed = 5f;
    public Vector2 direction;
    public Rigidbody2D rbody;
    // Start is called before the first frame update
    private const float changetime = 8f;
    public float changetimer;
    public bool RorL;

    private Vector2 beginposition;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        beginposition = rbody.position;
        if (RorL)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }
        changetimer = changetime;
    }

    // Update is called once per frame
    void Update()
    {
        changetimer -= Time.deltaTime;
        Vector2 position = rbody.position;
        position.x += direction.x * speed * Time.deltaTime;
        position.y += direction.y * speed * Time.deltaTime;
        if (changetimer < -1f)
        {
            transform.position=beginposition;
            changetimer = 8f;
        }
        rbody.position = position;
    }
}
