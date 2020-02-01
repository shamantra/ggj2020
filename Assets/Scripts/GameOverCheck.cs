using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCheck 
{
    static GameOverCheck _instance;
    bool bHasWon;
    RotatePiece[] rotatingTiles;
    GameObject winPanel;

    public static GameOverCheck getInstance()
    {
        if (_instance != null)
            return _instance;
        _instance = new GameOverCheck();
        return _instance;
    }

    public void checkWin()
    {
        bHasWon = false;
        rotatingTiles = GameObject.FindObjectsOfType<RotatePiece>();
        for (int i = 0; i < rotatingTiles.Length; i++)
        {
            bHasWon = true;
            if(rotatingTiles[i].getAnswerPosition()!=rotatingTiles[i].getRotationStatus())
            {
                bHasWon = false;
                break;
            }
        }
        if (bHasWon)
        {
            Debug.Log("Won");
            winPanel.SetActive(true);
        }
    }
}
