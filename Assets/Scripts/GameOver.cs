using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Transform ballTransform;
    [SerializeField]
    private List<GameObject> livesLeft;
    public GameObject gameOverUI;

    private void Update()
    {
        if(ballTransform.position.y <= -10.0f && livesLeft.Count > 1)
        {
            ballTransform.gameObject.GetComponent<BallController>().SpawnBall();
            RemoveHeart();
        }

        else if(ballTransform.position.y <= -10.0f)
        {
            Time.timeScale = 0;
            gameOverUI.SetActive(true);
            RemoveHeart();
        }
    }

    private void RemoveHeart()
    {
        Destroy(livesLeft[0]);
        livesLeft.RemoveAt(0);
    }
}
