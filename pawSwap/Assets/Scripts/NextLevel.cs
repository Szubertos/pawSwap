using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    public void OpenNextLevel()
    {
        int levelNumber = int.Parse(GameObject.Find("LevelNumber").GetComponent<TMP_Text>().text) + 1;
        string levelName = "Level " + levelNumber.ToString();
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(1);

        loadOperation.completed += (AsyncOperation) =>
        {
            Debug.Log("Level " + levelNumber.ToString());
            Debug.Log(levelName);
            GameObject levelToOpen = GameObject.Find(levelName);
            Debug.Log(levelToOpen);
            levelToOpen.GetComponent<Button>().onClick.Invoke();
            Debug.Log("3");
            GameObject loadLevelButton = GameObject.Find("LoadLevelButton");
            Debug.Log("2");
            loadLevelButton.GetComponent<Button>().onClick.Invoke();
            Debug.Log("1");
        };   
    }
}
