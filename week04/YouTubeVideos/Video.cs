
using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentSection = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void SetCommentSection(string name, string commentText)
    {
        Comment comment = new Comment(name, commentText);
        _commentSection.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _commentSection.Count;
    }

    public void GetVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");

        foreach (Comment comment in _commentSection)
        {
            Console.WriteLine($"\t{comment.GetCommenter()}: {comment.GetComment()}");
        }

        Console.WriteLine();
    }
}
