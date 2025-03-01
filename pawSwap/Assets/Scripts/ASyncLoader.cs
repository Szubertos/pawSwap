using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ASyncLoader : MonoBehaviour
{
    [Header ("Menu Screens")]
    [SerializeField] private GameObject loadingScreen;
    [SerializeField] private GameObject currentScreenUI;


    [Header ("Slider")]
    [SerializeField] private Slider loadingSlider;

    public int moves = 10;
    public int score = 1000;

    public void setMovesAndScore(int m, int s)
    {
        moves = m;
        score = s;
    }

    public void LoadLevelBtn(string levelToLoad)
    {
        currentScreenUI.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadLevelASync(levelToLoad));
    }

    IEnumerator LoadLevelASync(string levelToLoad)
    {
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);

        loadOperation.completed += (AsyncOperation) =>
        {
            GameObject scoreCounter = GameObject.Find("ScoreCounter");
            scoreCounter.GetComponent<ScoreCounter>().StartLevelSetScoreNeeded(score);

            GameObject moveCounter = GameObject.Find("MoveCounter");
            moveCounter.GetComponent<MoveCounter>().StartLevelSetMoves(moves);
        };

        while (!loadOperation.isDone)
        {
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            loadingSlider.value = progressValue;
            yield return null;
        }
    }
}
