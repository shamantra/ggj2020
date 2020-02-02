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
            if (Array.IndexOf(rotatingTiles[i].getAnswerPosition(), rotatingTiles[i].getRotationStatus())  ==-1)
            {
                bHasWon = false;
                break;
            }
        }
        if (bHasWon)
        {
            winPanel = GameObject.FindObjectOfType<PanelScript>().gameObject;
            if (PanelScript.levelCounter < 1)
            {
                winPanel.transform.GetChild(0).gameObject.SetActive(true);
                PanelScript.isPlayable = false;
            }
            else
            {
                winPanel.transform.GetChild(1).gameObject.SetActive(true);
                PanelScript.isPlayable = false;
            }
        }
    }
}
