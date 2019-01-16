using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScroller : MonoBehaviour
{

    private Text _textComponentToScroll;
    private int _timeScrolling;
    private string _fullTextValue;

    public int framesPerCharacter = 4;

    private void Start()
    {
        _fullTextValue = "";
        _textComponentToScroll = GetComponent<Text>();
        _textComponentToScroll.text = "";
        _timeScrolling = 0;
    }
    
    private void Update()
    {
       int charactersToShow = Math.Min(_fullTextValue.Length, (Time.frameCount - _timeScrolling) / framesPerCharacter);
       _textComponentToScroll.text = _fullTextValue.Substring(0, charactersToShow);
    }
    

    public void SetText(string textToScroll) {
        _fullTextValue = textToScroll;
        _timeScrolling = Time.frameCount;
    }
}
