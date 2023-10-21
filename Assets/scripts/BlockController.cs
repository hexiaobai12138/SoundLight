using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public float speed = 5f;
    public bool Isvertical;
    public Vector2 direction;
    public Rigidbody2D rbody;
    // Start is called before the first frame update
    private const float changetime = 3f;
    public float changetimer;
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        direction = Isvertical ? Vector2.up : Vector2.right;
        changetimer = changetime;
    }

    // Update is called once per frame
    void Update()
    {
        changetimer -= Time.deltaTime;
        if (changetimer < 0)
        {
            direction *= -1;
            changetimer = changetime;
        }
        Vector2 position = rbody.position;
        position.x += direction.x * speed * Time.deltaTime;
        position.y += direction.y * speed * Time.deltaTime;
        //rbody.MovePosition(position);
        rbody.position = position;
    }
}
