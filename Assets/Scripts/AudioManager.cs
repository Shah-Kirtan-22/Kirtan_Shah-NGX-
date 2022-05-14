using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> audioClip;  // a list of clips that can be accessed upon different triggers
    public AudioSource audioSource; 

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();  // store the audio source component for future use
    }

    // Usage of IEnumerator (Coroutine) allows the game to be paused until the audio clip is played

    public IEnumerator PlayAudioClip(int valueIndex)   // the value refers to the clip
    {
        audioSource.clip = audioClip[valueIndex];
        audioSource.Play();
        yield return new WaitForSeconds(audioSource.clip.length);
    }
}
