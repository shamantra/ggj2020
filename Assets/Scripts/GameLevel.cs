using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel
{
    public static GameLevel gameLevel;
    public static GameLevel getGameLevel()
    {

        if (gameLevel != null)
        {
            return gameLevel;
        }
        else
        {
            gameLevel = new GameLevel();
            return gameLevel;
        }
    }
    Layout level;
    public void setLevel(Layout _curr)
    {
        level = _curr;
    }
    public Layout getLevel()
    {
        return level;
    }
}
