using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    [Range(7,20)]
    private float m_Speed; // the speed at which the board moves
    private Transform m_Player;
    private float maxDistance = 7.6f;  // the distance from the board to either walls

    private void Start()
    {
        m_Speed = SceneManager.GetActiveScene().buildIndex + 10;
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
        if(m_Player.position.x < -maxDistance)  // check if the board is moved more than the screen width
        {
            m_Player.position = new Vector3(-maxDistance, m_Player.position.y, m_Player.position.z);
        }
        else
        {
            Vector3 nextPosition = m_Player.position;  // set the next position to be the current position (temp variable)
            nextPosition.x -= m_Speed * Time.deltaTime;  // to move left subtract the speed in the x direction (subtract ~ -x on the scale) && delta time to keep it uniform
            m_Player.position = nextPosition;
        }
    }
    
    private void MoveRight()
    {
        if(m_Player.position.x > maxDistance)
        {
            m_Player.position = new Vector3(maxDistance, m_Player.position.y, m_Player.position.z);
        }
        else
        {
            Vector3 nextPosition = m_Player.position;
            nextPosition.x += m_Speed * Time.deltaTime;
            m_Player.position = nextPosition;

        }
    }
}
