using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    [SerializeField]     
    [Range(6,15)]
    int speed = 6; // set the speed from the inspector

    void Start()
    {
        speed = speed + SceneManager.GetActiveScene().buildIndex;
        SpawnBall();
    }

    public void SpawnBall()
    {
        transform.position = Vector3.zero; // initalize at (0,0,0), can be at any position 
        this.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed; // randomly move the ball in any direction to begin the bounce effect   
    }

}
