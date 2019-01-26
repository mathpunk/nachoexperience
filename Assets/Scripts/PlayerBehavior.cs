using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private GameObject m_player;

    public enum PlayerState
    {
        Idle,
        WalkingLeft,
        WalkingRight,
        GoingUpstairs,
        GoingDownstairs,
        EnteringDoor,
        UsingCellPhone,
        ThinkingClue
    }

    // Use this for initialization
    void Start ()
    {
        m_player = GameObject.Find("PlayerSprite");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
