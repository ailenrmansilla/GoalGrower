using System.ComponentModel.DataAnnotations;

namespace GoalGrower.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Last Name field is required.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "The Password field is required.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
