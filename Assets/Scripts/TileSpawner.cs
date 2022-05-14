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


    private void Awake()
    {
        m_Rows = m_Tiles.Count;
        m_Columns = 6;

        for (int i = 0; i < m_Rows; i++ )
        {
            for(int j = 0; j < m_Columns; j++)
            {
                GameObject spawnedTile = Instantiate(m_Tiles[i], new Vector3(j * m_Tiles[i].transform.localScale.x, (i * m_Tiles[i].transform.localScale.y) + 1) + new Vector3(-6.25f,0,0) , Quaternion.identity);
                spawnedTiles.Add(spawnedTile);
            }
        }
    }
}
