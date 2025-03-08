using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelSelect : MonoBehaviour
{
    public int levelMoves = 10;
    public int levelScore = 1000;
    public int levelNumber = 1;

    public void ReplaceMovesAndScore()
    {
        GameObject scoreCounter = GameObject.Find("ASyncManager");
        scoreCounter.GetComponent<ASyncLoader>().setMovesScoreLevel(levelMoves, levelScore, levelNumber);
        GameObject LevelSelectName = GameObject.Find("Level Select Name");
        LevelSelectName.GetComponent<TMP_Text>().text = "Level " + levelNumber;
    }

    public void RetryLevel()
    {
        GameObject scoreCounter = GameObject.Find("ScoreCounter");
        int s = scoreCounter.GetComponent<ScoreCounter>().scoreNeeded;
        scoreCounter.GetComponent<ScoreCounter>().StartLevelSetScoreNeeded(s);
        GameObject moveCounter = GameObject.Find("MoveCounter");
        int m = moveCounter.GetComponent<MoveCounter>().maxMoves;
        moveCounter.GetComponent<MoveCounter>().StartLevelSetMoves(m);
    }

}
