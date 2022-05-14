using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    TileDestroy tileDestroy;

    private void Start()
    {
        scoreText.text += tileDestroy.destroyCount;
    }
}
