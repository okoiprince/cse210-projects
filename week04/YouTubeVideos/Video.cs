using System;

public class Video
{
    // Member Variables
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    // Constructor Declaration
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // Add comment method
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Count the number of comments from commenter
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Get the title of video
    public string GetTitle()
    {
        return _title;
    }

    // Get the Author of the video
    public string GetAuthor()
    {
        return _author;
    }

    // Get the length of video
    public int GetLength()
    {
        return _length;
    }

    //Display Comments
    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetCommentText()}");
        }
    }
}
