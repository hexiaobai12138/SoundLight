using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BGMcontroll : MonoBehaviour
{

    public List<AudioClip> AudioClipList;
    public float nowVolume=0.6f;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayMusic(int bgmid = 0)
    {
        audioSource.volume = nowVolume;
        audioSource.clip = AudioClipList[bgmid];
        audioSource.Play();
    }

    public void UnPauseMusic()
    {
        audioSource.volume = nowVolume;
        audioSource.UnPause();
    }

    public void PauseMusic()
    {
        audioSource.Pause();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

    public void FadeIn(float fadeTime)
    {
        StartCoroutine(FadeInCoroutine(fadeTime));
    }


    public void FadeOut(float fadeTime)
    {
        StartCoroutine(FadeOutCoroutine(fadeTime));
    }

    private IEnumerator FadeInCoroutine(float fadeTime)
    {
        float targetVolume = nowVolume;
        audioSource.volume = 0f;
        audioSource.UnPause();
        while (audioSource.volume < targetVolume)
        {

            audioSource.volume += 0.121f;
            yield return new WaitForSeconds(fadeTime);
        }
        audioSource.volume = targetVolume;
    }


    private IEnumerator FadeOutCoroutine(float fadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0f)
        {
            audioSource.volume -= startVolume * Time.deltaTime / fadeTime;
            yield return new WaitForSeconds(fadeTime);
        }
        audioSource.volume = 0f;
        audioSource.Pause();
        
    }
}
