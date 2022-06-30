using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    [HideInInspector]
    public int tileCount;
    [HideInInspector]
    public int finalScore;

    TileSpawner tileSpawner;
    TileDestroy tileDestroy;

    GameOver gameOver;
    public Text scoreText;

    [SerializeField]
    ScriptableValues scriptableValues;

    private void Start()
    {
        tileSpawner = GetComponent<TileSpawner>();
        tileDestroy = GameObject.FindObjectOfType<TileDestroy>();
        gameOver = GetComponent<GameOver>();

        scoreText = GameObject.Find("Score").GetComponent<Text>();

        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Debug.Log("Scene 1");
            finalScore = scriptableValues._Score = 0;
        }
        else
        {
            Debug.Log("Scene 2" + PlayerPrefs.GetInt("Score"));
            //finalScore = PlayerPrefs.GetInt("Score");
            finalScore = scriptableValues._Score;
        }

        scoreText.text = "Score: " + finalScore.ToString();
        //tileCount = tileSpawner.spawnedTiles.Count;  // get an initial count
    }

    public void ScoreDisplay()
    {
        //finalScore = ((tileCount - tileSpawner.spawnedTiles.Count) * 10) + ((gameOver.livesLeft.Count) * 250);

        finalScore += (10 * SceneManager.GetActiveScene().buildIndex);

        scriptableValues._Score = finalScore;

        scoreText.text = "Score: " + finalScore.ToString();
        PlayerPrefs.SetInt("Score", finalScore);
    }
}
