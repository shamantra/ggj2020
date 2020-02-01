using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel
{
    public static GameLevel gameLevel;
    public GameLevel()
    {
        if(gameLevel != null)
        {
            return;
        }
    }
    public Layout level;
    void setLevel(Layout _curr)
    {
        level = _curr;
    }
    Layout getLevel()
    {
        return level;
    }
}
