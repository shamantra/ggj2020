using System;
using UnityEngine;

[Serializable]
public class Layout
{
    public int level;
    public Block[] blocks;
}

[Serializable]
public class Block
{
    public int type;
    public Vector2 position;
    public int[] answerRotation;
    public int initialRotation;
    public bool isStatic;
    public bool inPath;
}
