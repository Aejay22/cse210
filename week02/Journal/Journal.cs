using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        Console.WriteLine("");
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].Display();
        }
        Console.WriteLine("");
    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            for (int i = 0; i < _entries.Count; i++)
            {
                outputFile.WriteLine($"{_entries[i]._date}|{_entries[i]._promptText}|{_entries[i]._entryText}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Console.WriteLine("");
        foreach (string line in lines)
        {
            Entry entry = new Entry();
            
            string[]parts = line.Split("|");
            Console.WriteLine($"{parts[0]}: {parts[1]}");
            Console.WriteLine($"{parts[2]}");
            
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            AddEntry(entry);
        }
        Console.WriteLine("");
        
    }
}