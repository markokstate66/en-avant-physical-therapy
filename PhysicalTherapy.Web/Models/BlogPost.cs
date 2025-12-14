namespace PhysicalTherapy.Web.Models;

public class BlogPost
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Excerpt { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Icon { get; set; } = "bi-journal-text";
    public DateTime PublishedDate { get; set; }
    public string Author { get; set; } = string.Empty;
    public int ReadTimeMinutes { get; set; }
}
