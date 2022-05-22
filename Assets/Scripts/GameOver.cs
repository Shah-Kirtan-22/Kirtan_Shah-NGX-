using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Transform ballTransform;  // obtain the position of the ball
    public List<GameObject> livesLeft;  // refers to the hearts/life the player has
    public GameObject gameOverUI; 
    AudioManager audioManager;
    ScoreManager scoreManager;

    private void Start()
    {
        audioManager = GetComponent<AudioManager>();
        scoreManager = GetComponent<ScoreManager>();
    }

    // In the update method, will check whether there are enough lives to go on and the ball is in the playing field
    // If not, then respawn the ball


    private void Update()
    {
        if(ballTransform.position.y <= -10.0f && livesLeft.Count > 1)
        {
            StartCoroutine(audioManager.PlayAudioClip(2));  // play the gameover audioclip

            ballTransform.gameObject.GetComponent<BallController>().SpawnBall();
            RemoveHeart();
        }

        else if(ballTransform.position.y <= -10.0f)
        {
            StartCoroutine(audioManager.PlayAudioClip(2));
            GameOverUI();
            RemoveHeart();
        }

        if(Input.GetKeyDown(KeyCode.Escape))  // if the escape key is pressed, the application will stop
        {
            QuitGame();
        }

    }

    // The gameoverUI is used to set the timescale to '0' ~ freezes the time for the game
    public void GameOverUI()  
    {
        Time.timeScale = 0;
        gameOverUI.SetActive(true);
    }

    // The removeheart method is used to remove the hearts in the UI as well as the list
    private void RemoveHeart()
    {
        Destroy(livesLeft[0]);
        livesLeft.RemoveAt(0);
    }

    // The restartgame method is called when starting the game
    // This method resets the game to its original state
    public void RestartGame()
    {
        SceneManager.LoadScene("Breakout");
        Time.timeScale = 1;
        ballTransform.gameObject.GetComponent<BallController>().SpawnBall();
    }

    // The quitgame method is used to quit the whole application
    public void QuitGame()
    {
        Application.Quit();
    }
}
