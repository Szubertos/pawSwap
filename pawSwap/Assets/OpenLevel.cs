using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLevel : MonoBehaviour
{
    //Scenes are opened based on their scene index, found by Clicking on File->Build Settings in Unity window.
    public void OpenMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void OpenMap()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void OpenSettings()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void OpenGameBoard()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
