using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

    public GameObject creditsView;

	void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnMouseDown()
    {
        creditsView.SetActive(false);
    }
}
