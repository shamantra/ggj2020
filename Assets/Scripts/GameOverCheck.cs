using System;
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
            if (rotatingTiles[i].getIsStatic()||!rotatingTiles[i].getIsPath())
                continue;
            bHasWon = true;
            if (Array.IndexOf(rotatingTiles[i].getAnswerPosition(), rotatingTiles[i].getRotationStatus())  !=-1)
            {
                bHasWon = false;
                break;
            }
        }
        if (bHasWon)
        {
            winPanel = GameObject.FindObjectOfType<PanelScript>().gameObject.transform.GetChild(0).gameObject;
            Debug.Log("Won");
            winPanel.SetActive(true);
        }
    }
}
