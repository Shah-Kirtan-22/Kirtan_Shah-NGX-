using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    [Range(2,10)]                       // adjust the speed in the inspector using a slider 
    int speed = 5;
    AudioManager audioManager;

    void Start()
    {
        audioManager = GetComponent<AudioManager>();
        SpawnBall();
    }

    public void SpawnBall()
    {
        transform.position = Vector3.zero; // initalize at (0,0,0), can be at any position 
        this.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed; // randomly move the ball in any direction to begin the bounce effect   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        StartCoroutine(audioManager.PlayAudioClip(0));
    }

}
