using UnityEngine;

public class LevelReader : MonoBehaviour
{
    int level;
    Layout currentLevel;

    private void Awake()
    {
        LoadLevel(++level);
    }

    public Layout LoadNextLevel()
    {
        return LoadLevel(level++);
    }

    Layout LoadLevel(int lvl)
    {
        TextAsset jsonFile = Resources.Load("level" + lvl) as TextAsset;

        level = lvl;
        currentLevel = JsonUtility.FromJson<Layout>(jsonFile.text);
        GameLevel.getGameLevel().setLevel(currentLevel);

        return currentLevel;
    }

    void Start()
    {
    }
}