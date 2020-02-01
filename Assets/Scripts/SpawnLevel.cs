using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLevel : MonoBehaviour
{
    Layout currentLevel;
    GameObject tileObject;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = GameLevel.gameLevel.level;
        foreach(Block block in currentLevel.blocks)
        {
            //RotatePiece temp = new RotatePiece(b)
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
