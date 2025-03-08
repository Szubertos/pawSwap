using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelCounter : MonoBehaviour
{
    private int levelNumber = 0;

    public void SetLevelNumber(int i)
    {
        levelNumber = i;
        this.GetComponent<TMP_Text>().text = levelNumber.ToString();
    }
}
