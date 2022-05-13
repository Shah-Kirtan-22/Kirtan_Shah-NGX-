using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private float m_Speed; // the speed at which the board moves
    private Transform m_Player;

    private void Start()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();  // get the transform of the player
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            MoveLeft(); // call the function for moving left
        }
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            MoveRight(); // call the function for moving right
        }
    }

    private void MoveLeft()
    {
        
        Vector3 nextPosition = m_Player.position;  // set the next position to be the current position (temp variable)
        nextPosition.x -= m_Speed * Time.deltaTime;  // to move left subtract the speed in the x direction (subtract ~ -x on the scale) && delta time to keep it uniform
        m_Player.position = nextPosition;


        //Debug.Log("Left arrow pressed");

    }
    
    private void MoveRight()
    {
        Vector3 nextPosition = m_Player.position;
        nextPosition.x += m_Speed * Time.deltaTime;
        m_Player.position = nextPosition; 
     
        //Debug.Log("Right arrow pressed");
    }
}
