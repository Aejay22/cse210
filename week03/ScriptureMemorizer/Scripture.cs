using System;
using System.Collections.Generic;
using System.IO.Pipelines;
public class Scripture
{    
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture (Reference Reference, string text)
    {
        _reference = Reference;
       string [] words = text.Split(" ");
       foreach (string word in words)
        {
            Word word1 = new Word(word);
            word1.Show();
            _words.Add(word1);

        }
    } 
    public void HideRandomWords(int numberToHide)
    {
        while(numberToHide > 0)
        {
            var results = _words.Where(word => !(word.IsHidden())).ToList();
            if (results.Count == 0){
                break;
            }
            Random random = new Random();
            int number = random.Next(results.Count);
            results[number].Hide();
            numberToHide -= 1;
        }
    }
    public string GetDisplayText()
    {
        string text = "";
        text +=_reference.GetDisplayText() + " ";
        int i = 0;
        while (i < _words.Count)
        {
            text += _words[i].GetDisplayText() + " ";
            i++;        
        }
        return text;
    }
    public bool IsCompletelyHidden()
    {
        if (_words.Any(word => !(word.IsHidden())))
        {
            return false;
        }
        else {return true;}
    }
}
