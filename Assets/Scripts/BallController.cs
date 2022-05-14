using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]     
    [Range(5,12)]
    int speed = 7; // set the speed from the inspector

    void Start()
    {
        SpawnBall();
    }

    public void SpawnBall()
    {
        transform.position = Vector3.zero; // initalize at (0,0,0), can be at any position 
        this.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed; // randomly move the ball in any direction to begin the bounce effect   
    }

}
