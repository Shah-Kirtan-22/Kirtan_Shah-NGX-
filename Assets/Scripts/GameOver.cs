using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Transform ballTransform;
    public List<GameObject> livesLeft;
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
            GameOverUI();
            RemoveHeart();
        }
    }

    public void GameOverUI()
    {
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }

    private void RemoveHeart()
    {
        Destroy(livesLeft[0]);
        livesLeft.RemoveAt(0);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Breakout");
        Time.timeScale = 1;
        ballTransform.gameObject.GetComponent<BallController>().SpawnBall();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
