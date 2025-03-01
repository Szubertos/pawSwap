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

    public void replaceMovesAndScore()
    {
        GameObject scoreCounter = GameObject.Find("ASyncManager");
        scoreCounter.GetComponent<ASyncLoader>().setMovesAndScore(levelMoves, levelScore);
        GameObject LevelSelectName = GameObject.Find("Level Select Name");
        LevelSelectName.GetComponent<TMP_Text>().text = "Level " + levelNumber;
    }

}
