﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLevel : MonoBehaviour
{
    Layout currentLevel;
    [SerializeField]
    GameObject tileObject;

    public delegate void StartGameEvent(Block[] blocks);
    public static event StartGameEvent OnStartGame;
    // Start is called before the first frame update
    void Start()
    {
        //OnStartGame += startGame;
        currentLevel = GameLevel.getGameLevel().getLevel();
        foreach (Block block in currentLevel.blocks)
        {
            GameObject tempBlock = Instantiate(tileObject);
            tempBlock.GetComponent<RotatePiece>().setRotationStatus(block.initialRotation);
            tempBlock.GetComponent<RotatePiece>().setPosition(block.position);
            tempBlock.GetComponent<RotatePiece>().setType(block.type);
            tempBlock.GetComponent<RotatePiece>().setAnswerPosition(block.answerRotation);
            tempBlock.GetComponent<RotatePiece>().setBIsStatic(block.bIsStatic);
        }

    }
    // Update is called once per frame
    void Update()
    {

        
    }
}
