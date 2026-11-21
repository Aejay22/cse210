
public class Comment
{
    private string _commenter;
    private string _comment;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public string GetCommenter()
    {
        return _commenter;
    }

    public string GetComment()
    {
        return _comment;
    }
}
