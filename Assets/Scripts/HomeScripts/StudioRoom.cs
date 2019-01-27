using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudioRoom : HomeRoomBase
{
    protected override string GetHint()
    {
        var rnd = Random.Range(0, m_hints.Studio.Length - 1);
        return m_hints.Studio[rnd];
    }

    // Use this for initialization
    void Start ()
    {
        m_roomName = GameObject.Find("StudioRoom");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}