using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<List<string>> _commentSection = new List<List<string>>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void SetCommentSection(string name, string commet)
    {
        Comment comment = new Comment(name, commet);
        _commentSection.Add(comment.ReturnComment());
    }
    public void GetVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comment ({_commentSection.Count}): ");
        for(int i = 0; i < _commentSection.Count; i++)
        {
            Console.WriteLine($"\t{_commentSection[i][0]}: {_commentSection[i][1]}");
        }
        Console.WriteLine("");
    }


}