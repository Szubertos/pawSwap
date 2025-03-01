using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public TMP_Text scoreCounter;
    public GameObject WinScreen;
    private int score = 0;
    private int scoreNeeded = 1000;

    public void StartLevelSetScoreNeeded(int s)
    {
        scoreNeeded = s;
    }

    public void AddScore(int s)
    {
        score = score + s;
        scoreCounter.text = score.ToString();

        if (score >= scoreNeeded)
        {
            Win();
        }
    }

    public void Win()
    {
        WinScreen.SetActive(true);
    }
}
