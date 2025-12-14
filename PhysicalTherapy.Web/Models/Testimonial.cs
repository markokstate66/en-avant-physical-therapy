namespace PhysicalTherapy.Web.Models;

public class Testimonial
{
    public int Id { get; set; }
    public string Quote { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public string AuthorTitle { get; set; } = string.Empty;
    public int Rating { get; set; } = 5;
    public string ChildAge { get; set; } = string.Empty;
    public string ServiceUsed { get; set; } = string.Empty;
}
