using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool[] dirs= new bool[4];
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dirs[0] = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dirs[1] = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dirs[2] = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dirs[3] = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dirs[4] = true;
        }
    }
    void CameraMove(int x,int y,float time)
    {
        transform.DOMoveX(x, time, (false));
        transform.DOMoveY(y, time, (false));
    }
    
}

