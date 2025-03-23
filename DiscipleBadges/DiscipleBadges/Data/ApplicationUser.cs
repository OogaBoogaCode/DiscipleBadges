using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DiscipleBadges.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    [Required]
    string HomeChurch;

    [Required]
    string FirstName;

    [Required]
    string LastName;
}

