using System.ComponentModel.DataAnnotations;

namespace BlazorTestProject.Models;

public class UserModel
{
    [Required(ErrorMessage = "Name is required.")]
    [StringLength(100, ErrorMessage = "Name must be 100 characters or fewer.")]
    public string? Name { get; set; }

    [StringLength(200, ErrorMessage = "Address must be 200 characters or fewer.")]
    public string? Address { get; set; }

    [Required(ErrorMessage = "Age is required.")]
    [Range(18, 120, ErrorMessage = "Age must be between 18 and 120.")]
    public int? Age { get; set; }

    [Required(ErrorMessage = "Email address is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string? Email { get; set; }
}
