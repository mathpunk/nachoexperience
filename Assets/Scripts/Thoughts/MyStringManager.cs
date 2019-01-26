using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyStringManager : MonoBehaviour {

    string sampleStr = "This is a test to see if this script actually works.";

    int strIndex = 0;

    float currentTime = Mathf.Epsilon, maxTime = 1f;

    [Range(1, 60)]
    [SerializeField]
    float speechSpeed = 20f;

    Text text;

	// Use this for initialization
	void Start () {
        text = gameObject.GetComponent<Text>();
        text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        
        text.text += sampleStr[strIndex];
	}
}
