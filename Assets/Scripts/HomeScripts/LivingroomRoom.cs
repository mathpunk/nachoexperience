using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingroomRoom : HomeRoomBase
{
    protected override string GetHint()
    {
        var rnd = Random.Range(0, m_hints.LivingRoom.Length - 1);
        return m_hints.LivingRoom[rnd];
    }

    // Use this for initialization
    void Start ()
    {
        m_roomName = GameObject.Find("LivingroomRoom");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
