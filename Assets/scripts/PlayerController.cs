using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���ƽ�ɫ�ƶ�
public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public int maxhp = 10;
    public int minhp = 0;
    public int hp = 10;
    public Rigidbody2D rbody;

    AudioSource m_AudioSource;
    Vector3 m_Movement;     //�ƶ�����

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); //ˮƽ����AD
        float vertical = Input.GetAxis("Vertical");     //��ֱ����WS
        m_Movement = new Vector3(horizontal * Time.deltaTime * speed, vertical * Time.deltaTime * speed, 0);


        //���������ж��Ƿ�������
        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f); //horizontal��0�Ƿ��Լ���
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);     //vertical��0�Ƿ��Լ���
        bool isWalking = hasHorizontalInput || hasVerticalInput;        //�����ˮƽ������ֱ���룬���ж�Ϊ������

        transform.Translate(m_Movement);//�ƶ�

        //���ýŲ���
        if (isWalking)                      //����ڽ�ɫ����    
        {
            if (!m_AudioSource.isPlaying)   //�ҽŲ������ڲ���
            {
                m_AudioSource.Play();       //���ŽŲ���
            }
        }
        else
        {
            m_AudioSource.Stop();           //������ʱֹͣ����
        }

    }
}
