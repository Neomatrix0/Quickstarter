using Microsoft.AspNetCore.Identity;
using Quickstarter.Models;

public class ApplicationUser : IdentityUser
{
    // Additional properties if needed, such as Full Name, etc.
    public ICollection<Contribution> Contributions { get; set; }  // Relation with Contributions
    public ICollection<Badge> Badges { get; set; }  // Relation with Badges
    public string IdentificationNumber { get; set; }
    public ICollection<ProjectStartup> Projects { get; set; }
}