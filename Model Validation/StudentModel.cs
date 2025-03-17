using System;
using System.ComponentModel.DataAnnotations;

public class StudentModel
{
    [Required(ErrorMessage = "Student Name is required.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters.")]
    [Display(Name = "Full Name")]
    public string Name { get; set; }

    [Range(18, 120, ErrorMessage = "Age must be between 18 and 120.")]
    [Display(Name = "Age")]
    public int Age { get; set; }

    [EmailAddress(ErrorMessage = "Invalid email address.")]
    [Required(ErrorMessage = "Email address is required.")]
    [Display(Name = "Email Address")]
    public string Email { get; set; }

    [Phone(ErrorMessage = "Invalid phone number.")]
    [Required(ErrorMessage = "Phone number is required.")]
    [Display(Name = "Phone Number")]
    public string Phone { get; set; }

    [Compare("ConfirmPassword", ErrorMessage = "Passwords do not match.")]
    [Display(Name = "Password")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirm Password is required.")]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set; }

    [RegularExpression(@"^[A-Za-z0-9_]+$", ErrorMessage = "Username can only contain alphanumeric characters and underscores.")]
    [StringLength(20, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 20 characters.")]
    [Display(Name = "Username")]
    public string Username { get; set; }

    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}
