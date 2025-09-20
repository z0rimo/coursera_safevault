
using System.ComponentModel.DataAnnotations;

namespace SafeVault;

public class RegisterUserDto
{
    [Required]
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression(@"^[A-Za-z0-9_\-\.]+$", ErrorMessage = "Username allows A-Z, a-z, 0-9, _-.")]
    public string Username { get; set; } = default!;

    [Required, EmailAddress, StringLength(254)]
    public string Email { get; set; } = default!;

    [Required]
    [StringLength(64, MinimumLength = 12, ErrorMessage = "Password must be at least 12 characters.")]
    public string Password { get; set; } = default!;
}
