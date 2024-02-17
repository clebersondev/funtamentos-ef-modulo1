namespace BlogEF.Models;
public class Post
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int AuthorId { get; set; }
    public string Title { get; set; } = String.Empty;
    public string Summary { get; set; } = String.Empty;
    public string Slug { get; set; } = String.Empty;
    public DateTime CreateDate { get; set; }
    public DateTime LastUpdateDate { get; set; }
}