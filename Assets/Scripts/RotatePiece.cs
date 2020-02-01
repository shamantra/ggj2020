using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePiece : MonoBehaviour
{
    const float SIZE_X=1;
    const float OFFSET_X=-5.5f;
    const float SIZE_Y=1;
    const float OFFSET_Y = 2.5f;
    public RotatePiece(int _rotateStatus, int _type, Vector2 _position,int _answerPosition)
    {
        rotationStatus = _rotateStatus;
        type = _type;
        position = _position;
    }
    int rotationStatus;
    int type;
    Vector2 position;
    int[] answerPosition;
    bool bIsStatic;
    bool isPath;
    [SerializeField]
    Sprite[] pipes; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = pipes[type];
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90 * rotationStatus));
        transform.position = new Vector2(position.x*SIZE_X+OFFSET_X,position.y*-SIZE_Y+OFFSET_Y);
    }
    public void setRotationStatus(int _rotation)
    {
        rotationStatus = _rotation;
    }
    public int getRotationStatus()
    {
        return rotationStatus;
    }
    public void setType(int _type)
    {
        type = _type;
    }
    public int getType()
    {
        return type;
    }
    public void setPosition(Vector2 _position)
    {
        position = _position;
    }
    public Vector2 getPosition()
    {
        return position;
    }
    public void setAnswerPosition(int[] _answerPosition)
    {
        answerPosition = _answerPosition;
    }
    public int[] getAnswerPosition()
    {
        return answerPosition;
    }
    public bool getIsStatic()
    {
        return bIsStatic;
    }
    public void setBIsStatic(bool _bIsStatic)
    {
        bIsStatic = _bIsStatic;
    }

    public bool getIsPath()
    {
        return isPath;
    }
    public void setIsPath(bool _isPath)
    {
        isPath = _isPath;
    }
    private void OnMouseDown()
    {
        if (bIsStatic)
            return;
        transform.Rotate(0, 0, 90);
        rotationStatus += 1;
        rotationStatus = rotationStatus >= 4 ? 0 : rotationStatus;
        GameOverCheck.getInstance().checkWin();
    }
}
