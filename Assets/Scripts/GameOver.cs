using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Transform ballTransform;
    [SerializeField]
    private List<GameObject> livesLeft;
    public GameObject gameOverUI;
    AudioManager audioManager;

    private void Start()
    {
        audioManager = GetComponent<AudioManager>();
    }

    private void Update()
    {
        if(ballTransform.position.y <= -10.0f && livesLeft.Count > 1)
        {
            StartCoroutine(audioManager.PlayAudioClip(2));
            ballTransform.gameObject.GetComponent<BallController>().SpawnBall();
            RemoveHeart();
        }

        else if(ballTransform.position.y <= -10.0f)
        {
            StartCoroutine(audioManager.PlayAudioClip(2));
            Time.timeScale = 0;
            gameOverUI.SetActive(true);
            RemoveHeart();
        }
    }

    private void RemoveHeart()
    {
        Destroy(livesLeft[0]);
        livesLeft.RemoveAt(0);
    }
}
