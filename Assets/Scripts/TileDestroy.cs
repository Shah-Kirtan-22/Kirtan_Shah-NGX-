using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroy : MonoBehaviour
{
    TileSpawner tileSpawner;
    GameOver gameOver;
    ScoreManager scoreManager;

    private void Start()
    {
        tileSpawner = GameObject.FindGameObjectWithTag("GameManager").GetComponent<TileSpawner>();
        scoreManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreManager>();
        gameOver = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameOver>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        tileSpawner.spawnedTiles.RemoveAt(0);  // simply remove the element from the list || A more efficient method would be to check the tag or use raycast
        Destroy(this.gameObject);  //  destroy the gameobject upon hit
        scoreManager.ScoreDisplay();
    }
}
