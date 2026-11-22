using System;
using System.Text.RegularExpressions;
public class Word
{    
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;  
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;   
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string hiddenCount = "";
            for (int i = 0; i < _text.Length; i++)
            {
                if(Regex.IsMatch(_text[i].ToString(), @"\w"))
                {
                    hiddenCount += "_";
                }
                else
                {
                    hiddenCount += _text[i];
                }
            }
            return hiddenCount;
        }
        else
        {
            return _text;
        }
    }
}