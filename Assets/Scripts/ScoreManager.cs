using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [HideInInspector]
    public int tileCount;
    [HideInInspector]
    public int finalScore;

    TileSpawner tileSpawner;
    GameOver gameOver;


    private void Start()
    {
        tileSpawner = GetComponent<TileSpawner>();
        gameOver = GetComponent<GameOver>();

        tileCount = tileSpawner.spawnedTiles.Count;  // get an initial count
    }


    public void ScoreDisplay()
    {
        finalScore = ((tileCount - tileSpawner.spawnedTiles.Count) * 10) + ((gameOver.livesLeft.Count) * 250);
        Debug.Log(finalScore);
    }
}
