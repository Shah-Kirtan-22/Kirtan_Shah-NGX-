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
    }


    public IEnumerator PlayAudioClip(int valueIndex)
    {
        audioSource.clip = audioClip[valueIndex];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
    }
}
