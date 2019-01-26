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

    int currentSceneIndex;

	// Use this for initialization
	void Start ()
    {
        GetSceneIndices();
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SetCurrentScene();
    }

    // Update is called once per frame
    void Update ()
    {
        SwitchScenes();
    }

    private void GetSceneIndices()
    {
        DefaultSceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/Default.unity");
        LoadingSceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/Loading.unity");
        MainMenuSceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/MainMenu.unity");
        GameOverSceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/GameOver.unity");
        DebugSceneIndex = SceneUtility.GetBuildIndexByScenePath("Assets/Scenes/Debug.unity");
    }

    private void SetCurrentScene()
    {
        if (currentSceneIndex == DefaultSceneIndex) currentScene = SceneList.DefaultScene;
        if (currentSceneIndex == LoadingSceneIndex) currentScene = SceneList.LoadingScene;
        if (currentSceneIndex == MainMenuSceneIndex) currentScene = SceneList.MainMenuScene;
        if (currentSceneIndex == GameOverSceneIndex) currentScene = SceneList.GameOverScene;
        if (currentSceneIndex == DebugSceneIndex) currentScene = SceneList.DebugScene;
    }

    private void SwitchScenes()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentScene = SceneList.MainMenuScene;
            LoadScene();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentScene = SceneList.LoadingScene;
            LoadScene();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentScene = SceneList.DefaultScene;
            LoadScene();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentScene = SceneList.GameOverScene;
            LoadScene();
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentScene = SceneList.DebugScene;
            LoadScene();
        }
    }

    private void LoadScene()
    {
        if (currentScene == SceneList.MainMenuScene) SceneManager.LoadScene(MainMenuSceneIndex);
        if (currentScene == SceneList.LoadingScene) SceneManager.LoadScene(LoadingSceneIndex);
        if (currentScene == SceneList.DefaultScene) SceneManager.LoadScene(DefaultSceneIndex);
        if (currentScene == SceneList.GameOverScene) SceneManager.LoadScene(GameOverSceneIndex);
        if (currentScene == SceneList.DebugScene) SceneManager.LoadScene(DebugSceneIndex);
    }
}
