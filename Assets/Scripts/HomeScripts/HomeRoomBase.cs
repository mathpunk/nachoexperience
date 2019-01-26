using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeRoomBase : MonoBehaviour
{
    public bool m_MemoryFound = false;

    protected GameObject m_roomName;

    protected Texture2D m_bwTexture;
    protected Texture2D m_colorTexture;

    protected Hints m_hints;

    virtual protected string GetHint()
    {
        return null;
    }

    // Use this for initialization
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }
}
