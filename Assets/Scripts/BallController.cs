using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    Vector3 forceApplied;
    [SerializeField]
    [Range(2,10)]
    int speed = 5;
    
    void Start()
    {
        transform.position = Vector3.zero;
        this.GetComponent<Rigidbody>().velocity = Random.insideUnitCircle.normalized * speed;    
    }


}
