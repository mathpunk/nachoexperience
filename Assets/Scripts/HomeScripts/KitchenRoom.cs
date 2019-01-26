using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenRoom : HomeRoomBase
{
    protected override string GetHint()
    {
        var rnd = Random.Range(0, m_hints.Kitchen.Length - 1);
        return m_hints.Kitchen[rnd];
    }

    // Use this for initialization
    void Start ()
    {
        m_roomName = GameObject.Find("KitchenRoom");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
