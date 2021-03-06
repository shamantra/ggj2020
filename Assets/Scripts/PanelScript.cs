﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    [SerializeField]
    SpawnLevel levelSpawner;
    public static int levelCounter =0;
    public static bool isPlayable;
    public void exitButton()
    {
        Application.Quit();
    }
    public void nextLevel()
    {
        levelCounter++;
        RotatePiece[] rotatePieces = GameObject.FindObjectsOfType<RotatePiece>();
        foreach(RotatePiece rotatePiece in rotatePieces)
        {
            Destroy(rotatePiece.gameObject);
        }
        transform.GetChild(0).gameObject.SetActive(false);
        GameLevel.getGameLevel().setLevel(GameObject.FindObjectOfType<LevelReader>().LoadNextLevel());
        levelSpawner.LoadLevel();
    }
}
