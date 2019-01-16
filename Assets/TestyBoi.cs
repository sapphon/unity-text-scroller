using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestyBoi : MonoBehaviour
{

    public string[] textsToSet;
    public int framesPerText = 60;

    private int _textIndex = -1;
    
    void Update()
    {
        if (Time.frameCount % framesPerText == 0)
        {
            FindObjectOfType<TextScroller>().SetText(GetNextText());
        }
    }

    private string GetNextText()
    {
        _textIndex = (_textIndex + 1) % textsToSet.Length;
        return textsToSet[_textIndex];
    }
}
