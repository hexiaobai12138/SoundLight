using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class postprocessing : MonoBehaviour
{
    public float intensity = 0;
    public GameObject Square;

    PostProcessVolume _volume;
    Vignette _vignette;
    float colorR, colorG, colorB;
    // Start is called before the first frame update
    void Start()
    {
        _volume = GetComponent<PostProcessVolume>();
        _volume.profile.TryGetSettings<Vignette>(out _vignette);
        
        if(!_vignette)
        {
            print("error,vigette empty");
        }
        else
        {
            _vignette.enabled.Override(false);
        }

    }

    public void Takedamage()
    {
        StartCoroutine(TakeDamage());
    }
    private IEnumerator TakeDamage()
    {
        colorR = 50f;
        colorG = 50f;
        colorB = 50f;
        intensity = 0.4f;
        Square.GetComponent<SpriteRenderer>().color = new Color(colorR/255f, colorG/255f, colorB / 255f);
        _vignette.enabled.Override(true);
        _vignette.intensity.Override(0.4f);
        yield return new WaitForSeconds(0.4f);

        while(intensity > 0)
        {
            intensity-=0.01f;colorR -= 1.5f;colorG -= 1.5f;colorB -= 1.5f;
            if(intensity < 0) intensity = 0;
            if(colorB < 0) colorB = 0;
            if(colorG<0)   colorG = 0;
            if(colorR<0) colorR = 0;
            _vignette.intensity.Override(intensity);
           Square.GetComponent<SpriteRenderer>().color = new Color(colorR / 255f, colorG / 255f, colorB / 255f);
            yield return new WaitForSeconds(0.05f);
        }
        _vignette.enabled.Override(false);
        yield break;
    }
}
