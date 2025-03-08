using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoveCounter : MonoBehaviour
{
    public TMP_Text moveCounter;
    public GameObject loseScreen;
    private int moves = 10;
    public int maxMoves = 10;

    public void StartLevelSetMoves(int m)
    {
        Debug.Log("123");
        moves = m;
        maxMoves = m;
        moveCounter.text = moves.ToString();
    }
    
    public void MoveMade()
    {
        moves--;
        moveCounter.text = moves.ToString();

        if (moves < 1)
        {
            Lose();
        }
    }

    public void Lose()
    {
        loseScreen.SetActive(true);
    }
}
