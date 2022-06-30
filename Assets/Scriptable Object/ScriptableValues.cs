using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableValues : ScriptableObject
{
    public int _Score;
    public int livesLeft;

    [SerializeField]
    public int Score
    {
        get { return _Score; }
        set { _Score = value; }
    }

    public int Heart
    {
        get { return livesLeft; }
        set { livesLeft = value; }
    }
}
