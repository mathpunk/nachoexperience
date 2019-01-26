using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public enum SceneList
    {
        DefaultScene,
        LoadingScene,
        MainMenuScene,
        GameOverScene,
        DebugScene
    }

    SceneList currentScene;

    int DefaultSceneIndex, LoadingSceneIndex,
        MainMenuSceneIndex, GameOverSceneIndex,
        DebugSceneIndex;

	// Use this for initialization
	void Start ()
    {
        currentScene = SceneList.DefaultScene;
        DefaultSceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/default.unity");
        DebugSceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/debug.unity");
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
