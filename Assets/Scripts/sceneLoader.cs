using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
    public void LoadDefinitionList()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene(1);
    }
    public void CloseProgram()
    {
        Application.Quit();
    }
}
