using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLevel : MonoBehaviour
{
    int[] levelData = { 0, 1, 2, 3 };
    GameObject tileObject;
    int length;
    // Start is called before the first frame update
    void Start()
    {
        float xpos = 0;
        float ypos = 0;
        for(int i =0; i<levelData.Length;i++)
        {
            ypos = (int)i / length;
            xpos = i % length;
            Instantiate(tileObject,new Vector3(xpos, ypos), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
