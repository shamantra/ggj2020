using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePiece : MonoBehaviour
{
    const int SIZE_X=1;
    const int OFFSET_X=1;
    const int SIZE_Y=1;
    const int OFFSET_Y = 1;
    public RotatePiece(int _rotateStatus, int _type, Vector2 _position)
    {
        rotationStatus = _rotateStatus;
        type = _type;
        position = _position;
    }
    public int rotationStatus;
    public int type;
    Vector2 position;
    [SerializeField]
    Sprite[] pipes; 
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = pipes[type];
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90 * rotationStatus));
        transform.position = new Vector2(position.x*SIZE_X+OFFSET_X,position.y*SIZE_Y+OFFSET_Y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);
        rotationStatus += 1;
        rotationStatus = rotationStatus >= 4 ? 0 : rotationStatus;
    }
}
