using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeRoomBase : MonoBehaviour
{
    public bool m_MemoryFound = false;

    protected GameObject m_roomName;
    protected Texture2D m_bwTexture;
    protected Texture2D m_colorTexture;
    protected HomeHints m_baseHints;

    // Use this for initialization
    void Start ()
    {
        // Get m_roomName in child class
	}
	
	// Update is called once per frame
	void Update ()
    {
	    // Select texture to render
        // Object will have two textures for it, color and b&w
	}
}
