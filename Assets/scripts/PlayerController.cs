using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//¿ØÖÆ½ÇÉ«ÒÆ¶¯
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public int maxhp = 10;
    public int minhp = 0;
    public int hp = 10;
    public Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.right * speed * Time.deltaTime);
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");
        Vector2 position = rbody.position;
        position.x += movex * speed * Time.deltaTime;
        position.y += movey * speed * Time.deltaTime;
        //rbody.MovePosition(position);
        
        rbody.position = position;
    }
}
