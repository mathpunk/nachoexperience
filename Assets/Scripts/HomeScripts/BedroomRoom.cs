using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomRoom : HomeRoomBase
{
    protected override string GetHint()
    {
        var rnd = Random.Range(0, m_hints.Bedroom.Length - 1);
        return m_hints.Bedroom[rnd];
    }

    // Use this for initialization
    void Start ()
    {
        m_roomName = GameObject.Find("BedroomRoom");

        //m_bwTexture = 
        //m_colorTexture =
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
