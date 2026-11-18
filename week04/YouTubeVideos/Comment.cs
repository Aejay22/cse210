using System;
public class Comment
{
    private string _commenter;
    private string _comment;
    public Comment(string commenter, string comment)
    {
        _comment = comment;
        _commenter = commenter;
    }
    public List<string> ReturnComment()
    {
        List<string> comment = new List<string>();
        comment.Add(_commenter);
        comment.Add(_comment);
        return comment;
    }
}