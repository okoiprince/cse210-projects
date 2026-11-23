using System;
public class Comment
{
    // Member Variables
    private string _commenterName;
    private string _commentText;

    // Constructor Declaration
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Getters for commenter name and text
    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}
