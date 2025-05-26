public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = [];

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void StoreComments(Comment here)
    {
        _comments.Add(here);
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }

}