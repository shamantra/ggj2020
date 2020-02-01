using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverCheck : MonoBehaviour
{
    bool bHasWon;
    int[] winningAnswer;
    RotatePiece[] rotatingTiles;
    GameObject winPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bHasWon = false;
        for(int i=0;i<winningAnswer.Length;i++)
        {
            bHasWon = true;
            if(winningAnswer[i]!=rotatingTiles[i].positionStatus)
            {
                bHasWon = false;

                break;
            }
        }
        if(bHasWon)
        {
            winPanel.SetActive(true);
        }
    }
}
