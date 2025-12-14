using System.ComponentModel.DataAnnotations;

namespace PhysicalTherapy.Web.Models;

public class ContactMessage
{
    [Required(ErrorMessage = "Please enter your name")]
    [StringLength(100, ErrorMessage = "Name is too long")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your email")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter your phone number")]
    [Phone(ErrorMessage = "Please enter a valid phone number")]
    public string Phone { get; set; } = string.Empty;

    public string ChildAge { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please select a service")]
    public string ServiceInterest { get; set; } = string.Empty;

    [Required(ErrorMessage = "Please enter a message")]
    [StringLength(2000, ErrorMessage = "Message is too long")]
    public string Message { get; set; } = string.Empty;

    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;
}
