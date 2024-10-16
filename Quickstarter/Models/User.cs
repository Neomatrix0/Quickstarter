public class User
{
    public string UserId { get; set; }  // Primary Key (mapped to IdentityUser's Id)
    public string FullName { get; set; }  // User's full name
    public string Email { get; set; }  // Email address, essential for communication and authentication
    public string Role { get; set; }  // Role (Admin, Startupper, Financier)

 /*   // Navigation properties
    public ICollection<Contribution> Contributions { get; set; }  // One user can have many contributions
    public ICollection<Badge> Badges { get; set; }  // One user can earn many badges
    public ICollection<Project> CreatedProjects { get; set; }  // One user can create multiple projects (Startupper role)*/
}
