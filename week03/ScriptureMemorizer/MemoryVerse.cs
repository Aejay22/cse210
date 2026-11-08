using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Security;
public class MemoryVerse
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _text;
    private Reference reference1;
    private List<string[]> _allVerses = new List<string[]>();
    public void LoadFromFile()
    {
        string[]lines = File.ReadAllLines("memoryVerse.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split("||");
            _allVerses.Add(parts);
        }
    } 
    public void GetMemoryVerse()
    {
        for(int i =0; i< _allVerses.Count; i++)
        {
            string[]parts = _allVerses[i];
            Console.WriteLine($"{i+1} {parts[0]} {parts[1]}");
        }
    }
    public void Answer(int response)
    {
        _book = _allVerses[response-1][0];
        _text = _allVerses[response-1][2];
        string[] chapterVerse = _allVerses[response-1][1].Split(new char []{':','-'});
        _chapter = int.Parse(chapterVerse[0]);
        _verse = int.Parse(chapterVerse[1]);
        if (chapterVerse.Length > 2)
        {
            _endVerse = int.Parse(chapterVerse[2]);
        }
        else
        {
            _endVerse = 0;
        }
    }

    


    public Scripture ReturnScripture()
    {
        if (_endVerse != 0)
        {
            reference1 = new Reference(_book, _chapter, _verse, _endVerse);
            
        }
        else
        {
            reference1 = new Reference(_book, _chapter, _verse);
            
        }
        
        
        Scripture scripture1 = new Scripture(reference1, _text);
        return scripture1;
    }
        
        
        

}