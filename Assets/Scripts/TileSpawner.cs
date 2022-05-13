using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> m_Tiles;
    private int m_Rows;
    private int m_Columns;

    private void Start()
    {
        m_Rows = m_Tiles.Count;
        m_Columns = 13;

        for (int i = 0; i < m_Rows; i++ )
        {
            for(int j = 0; j < m_Columns; j++)
            {
                Instantiate(m_Tiles[i], new Vector3(j * m_Tiles[i].transform.localScale.x, (i * m_Tiles[i].transform.localScale.y) + 2) + new Vector3(-7.5f,0,0) , Quaternion.identity);
            }
        }
    }

}
