using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileDestroy : MonoBehaviour
{
    TileSpawner tileSpawner;
    GameOver gameOver;
    ScoreManager scoreManager;

    private static int hitCount;
    [Range(1,7)]
    public int destroyHit;      // hits to destroy

    private void Start()
    {
        tileSpawner = GameObject.FindGameObjectWithTag("GameManager").GetComponent<TileSpawner>();
        scoreManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreManager>();
        gameOver = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameOver>();

        hitCount = 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        ++hitCount;
        if(hitCount >= destroyHit)
        {
            tileSpawner.spawnedTiles.RemoveAt(0);  // simply remove the element from the list || A more efficient method would be to check the tag or use raycast
            Destroy(this.gameObject);  //  destroy the gameobject upon hit
            scoreManager.ScoreDisplay();
            hitCount = 0;
        }
    }
}
