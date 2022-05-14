using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> audioClip;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip[3];
        audioSource.Play();
    }


    public IEnumerator PlayAudioClip(int valueIndex)
    {
        audioSource.clip = audioClip[valueIndex];
        audioSource.Play();
        Debug.Log(audioSource.clip.length);
        yield return new WaitForSeconds(audioSource.clip.length);
    }

    /*
    public void PlayAudioClip(int valueIndex)
    {
            audioSource.clip = audioClip[valueIndex];
            audioSource.Play();
        
    }*/
}
