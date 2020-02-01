using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePiece : MonoBehaviour
{
    public int positionStatus;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        positionStatus = (int)rot.z / 90;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        transform.Rotate(0, 0, 90);
        positionStatus += 1;
        positionStatus = positionStatus >= 4 ? 0 : positionStatus;
    }
}
