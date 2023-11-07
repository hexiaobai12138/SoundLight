using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoFaIconCar : MonoBehaviour
{
    public ParticleSystem particleSystem;
    private ParticleSystem.Particle[] particlesArray;//储存粒子的数组
    public int particleNumber = 5000;
    public float radiusOriginal = -0.5f;
    //public float radiusIncrease = 1.0f;
    public float speed = 1f;


    int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.parent.position;

        particlesArray = new ParticleSystem.Particle[particleNumber];//将储存粒子的数组初始化
        particleSystem.maxParticles = particleNumber;//设置粒子发射的最大数量
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

            particleSystem.Emit(particleNumber);//将刚刚初始化的particleNumber个粒子发射出去
            particleSystem.GetParticles(particlesArray);
            for (int i = 0; i < particleNumber; i++)
            {//为每个粒子设置其位置
                float angle = Random.Range(0.0f, 360.0f);//位置为0 - 360度的随机一个角度
                particlesArray[i].position = new Vector3(radiusOriginal * Mathf.Cos(angle), radiusOriginal * Mathf.Sin(angle), 0.0f);//为每个粒子坐标赋值
                particlesArray[i].position += transform.position;


                Vector3 particlePosition = particlesArray[i].position;
                Vector3 objectPosition = transform.position;
                Vector3 vector2target = particlePosition - objectPosition;

                particlesArray[i].velocity = vector2target.normalized * speed;

            }

            particleSystem.SetParticles(particlesArray, particlesArray.Length);//设置该粒子系统的粒子。
        }



    }

}

