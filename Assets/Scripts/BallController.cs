using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    [Range(2,10)]
    int speed = 5;
    
    void Start()
    {
        Respawn();
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        this.GetComponent<Rigidbody2D>().velocity = Random.insideUnitCircle.normalized * speed;
    }

}
