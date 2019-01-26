using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudioRoom : HomeRoomBase
{
    private string[] m_studioHints;

    public string GetHint()
    {
        var rnd = Random.Range(0, m_studioHints.Length - 1);
        return m_studioHints[rnd];
    }

	// Use this for initialization
	void Start ()
    {
        // Get strings for this room
        m_studioHints = m_baseHints.StudioHints;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
