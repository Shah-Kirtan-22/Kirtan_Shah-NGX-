using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [HideInInspector]
    public int tileCount;
    [HideInInspector]
    public int finalScore;

    TileSpawner tileSpawner;
    GameOver gameOver;
    public Text scoreText;


    private void Start()
    {
        tileSpawner = GetComponent<TileSpawner>();
        gameOver = GetComponent<GameOver>();

        scoreText = GameObject.Find("Score").GetComponent<Text>();

        tileCount = tileSpawner.spawnedTiles.Count;  // get an initial count
    }

    public void ScoreDisplay()
    {
        //finalScore = ((tileCount - tileSpawner.spawnedTiles.Count) * 10) + ((gameOver.livesLeft.Count) * 250);
        finalScore = ((tileCount - tileSpawner.spawnedTiles.Count) * 10);
        scoreText.text = "Score: " + finalScore.ToString();
    }
}
