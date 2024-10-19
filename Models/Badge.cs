using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quickstarter.Models
{
    public class Badge
{
    public int BadgeId { get; set; }  // Primary key
    public string Name { get; set; }  // Badge name (e.g., "Top Contributor", "Monthly Leader")
    public string Description { get; set; }  // Badge description
    public DateTime AwardedAt { get; set; }  // Date the badge was awarded

    public string UserId { get; set; }  // Foreign key from ApplicationUser
    public ApplicationUser User { get; set; }  // Navigation to User
}
}