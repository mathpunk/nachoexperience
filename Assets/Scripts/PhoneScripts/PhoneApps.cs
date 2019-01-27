using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneApps : MonoBehaviour {

    string whatApp;
    public GameObject phoneView;
    public GameObject credits;
    
    public AudioSource phoneSounds;
    public AudioClip tapSounds;
    private IEnumerator pauseForSound;

    void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnMouseDown()
    {
        whatApp = gameObject.name;

        switch (whatApp)
        {
            case "CameraClickArea":
                Debug.Log("Clicked Camera");
                //Check for Camera Trigger
                break;
            case "RecorderClickArea":
                Debug.Log("Clicked Recorder");
                //Check for Music Trigger
                break;
            case "LightClickArea":
                Debug.Log("Clicked Light");
                //Check for Animal Trigger
                break;
            case "PayClickArea":
                Debug.Log("Clicked Pay");
                //Check for Food Trigger
                break;
            case "CommunicationClickArea":
                Debug.Log("Clicked Comm");
                //Credits go here
                
                credits.SetActive(true);

                break;
            case "WeatherClickArea":
                Debug.Log("Clicked Weather");
                //Joke goes here
                break;
            default:
                break;
        }

        phoneSounds = GetComponent<AudioSource>();
        phoneSounds.PlayOneShot(tapSounds, 1);

        pauseForSound = PauseForSound();
        StartCoroutine(pauseForSound);

        //phoneView.SetActive(false);
    }

    private IEnumerator PauseForSound()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.3f);
            phoneView.SetActive(false);
        }
    }
}
