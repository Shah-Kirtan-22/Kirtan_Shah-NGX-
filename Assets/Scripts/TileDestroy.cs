using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroy : MonoBehaviour
{
    TileSpawner tileSpawner;
    GameOver gameOver;

    private void Start()
    {
        tileSpawner = GameObject.FindGameObjectWithTag("GameManager").GetComponent<TileSpawner>();
        gameOver = GameObject.FindGameObjectWithTag("GameManger").GetComponent<GameOver>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        tileSpawner.spawnedTiles.RemoveAt(0);
        Destroy(this.gameObject);
    }
    
    private void FixedUpdate()
    {
        if(tileSpawner.spawnedTiles.Count < 0)
        {
            gameOver.GameOverUI();
        }
    }
}
