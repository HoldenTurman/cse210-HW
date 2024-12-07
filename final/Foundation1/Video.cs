public class Video
{

    //Attributes: title, author, length in seconds
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    //Create a new List for comments to be stored
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    //Getter Methods for Attributes
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthSeconds()
    {
        return _lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Returns a copy of the _comments list, rather than a direct reference to the original list.

    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }
}
