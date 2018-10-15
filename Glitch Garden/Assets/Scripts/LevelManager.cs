using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour

{


    public float autoLoadNextLevelAfter;

    void Start()
    {
        if (autoLoadNextLevelAfter == 0)
        {

        }
        else
        {
            Invoke("LoadNextScene", autoLoadNextLevelAfter);
        }
    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadLevel(string name)
    {
        Application.LoadLevel(name);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}