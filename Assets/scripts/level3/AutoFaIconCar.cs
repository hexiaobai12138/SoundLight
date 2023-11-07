using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoFaIconCar : MonoBehaviour
{
    public ParticleSystem particleSystem;
    private ParticleSystem.Particle[] particlesArray;//�������ӵ�����
    public int particleNumber = 5000;
    public float radiusOriginal = -0.5f;
    //public float radiusIncrease = 1.0f;
    public float speed = 1f;


    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.parent.position;

        particlesArray = new ParticleSystem.Particle[particleNumber];//���������ӵ������ʼ��
        particleSystem.maxParticles = particleNumber;//�������ӷ�����������
        particleSystem.GetParticles(particlesArray);
      

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.parent.position;
        cnt++;
        if (cnt==1000)
        {
            cnt = 0;

            particleSystem.Emit(particleNumber);//���ոճ�ʼ����particleNumber�����ӷ����ȥ
            particleSystem.GetParticles(particlesArray);
            for (int i = 0; i < particleNumber; i++)
            {//Ϊÿ������������λ��
                float angle = Random.Range(0.0f, 360.0f);//λ��Ϊ0 - 360�ȵ����һ���Ƕ�
                particlesArray[i].position = new Vector3(radiusOriginal * Mathf.Cos(angle), radiusOriginal * Mathf.Sin(angle), 0.0f);//Ϊÿ���������긳ֵ
                particlesArray[i].position += transform.position;


                Vector3 particlePosition = particlesArray[i].position;
                Vector3 objectPosition = transform.position;
                Vector3 vector2target = particlePosition - objectPosition;

                particlesArray[i].velocity = vector2target.normalized * speed;

            }

            particleSystem.SetParticles(particlesArray, particlesArray.Length);//���ø�����ϵͳ�����ӡ�
        }



    }

}

