using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> m_Tiles;   // tiles prefab
    public List<GameObject> spawnedTiles = new List<GameObject>();      // store the spawned  tiles
    private int m_Rows;
    private int m_Columns;

    GameOver gameOver;

    private void Awake()
    {
        m_Rows = m_Tiles.Count;
        m_Columns = 6;  // combination of tiles (x-value) and screen width || A more efficient method would be to use Screen.Width

        for (int i = 0; i < m_Rows; i++ )
        {
            for(int j = 0; j < m_Columns; j++)
            {
                // spawn tiles starting from columns and then add them to the spawned list
                GameObject spawnedTile = Instantiate(m_Tiles[i], new Vector3(j * m_Tiles[i].transform.localScale.x, (i * m_Tiles[i].transform.localScale.y) + 1) + new Vector3(-6.25f,0,0) , Quaternion.identity);
                spawnedTiles.Add(spawnedTile);
            }
        }
    }

    private void Start()
    {
        gameOver = GetComponent<GameOver>();
    }

    private void Update()
    {
        if(spawnedTiles.Count <= 0)
        {
            //gameOver.GameOverUI();
            gameOver.LevelManager();
        }
    }
}
