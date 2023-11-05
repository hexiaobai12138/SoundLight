using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//控制角色移动
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public int maxhp = 10;
    public int minhp = 0;
    public int hp = 10;
    public Rigidbody2D rbody;

    AudioSource m_AudioSource;
    Vector3 m_Movement;     //移动向量

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //水平输入AD
        float vertical = Input.GetAxis("Vertical");     //竖直输入WS
        m_Movement = new Vector3(horizontal * Time.deltaTime * speed, vertical * Time.deltaTime * speed, 0);


        //根据输入判断是否在行走
        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f); //horizontal与0是否大约相等
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);     //vertical与0是否大约相等
        bool isWalking = hasHorizontalInput || hasVerticalInput;        //如果有水平或者竖直输入，则判断为在行走

        transform.Translate(m_Movement);//移动

        //设置脚步声
        if (isWalking)                      //如果在角色行走    
        {
            if (!m_AudioSource.isPlaying)   //且脚步声不在播放
            {
                m_AudioSource.Play();       //播放脚步声
            }
        }
        else
        {
            m_AudioSource.Stop();           //不行走时停止播放
        }

    }
}
