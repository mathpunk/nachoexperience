using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    #region PlayerBehavior Private Members

    GameObject m_player;

    // Where am I (home room, city block)
    // PlayerStateManger member class

    #endregion

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
