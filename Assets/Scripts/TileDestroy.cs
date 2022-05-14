using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroy : MonoBehaviour
{
    [HideInInspector]
    public int destroyCount;
    AudioManager audioManager;

    private void Start()
    {
        destroyCount = 0;
        audioManager = GetComponent<AudioManager>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject);

        StartCoroutine(audioManager.PlayAudioClip(1));
        destroyCount++;
        Debug.Log(destroyCount);
    }
}
