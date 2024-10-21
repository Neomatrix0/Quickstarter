using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quickstarter.Models
{
public class Contribution
{
    public int ContributionId { get; set; }  // Primary key
    public decimal Amount { get; set; }  // Amount contributed
    public DateTime ContributedAt { get; set; }  // Date of contribution

    // Foreign keys
    public string FinancierId { get; set; }  // Foreign key from ApplicationUser
    public ApplicationUser Financier { get; set; }  // Navigation to Financier
    
    public int ProjectId { get; set; }  // Foreign key from Project
    public ProjectStartup ProjectStartup { get; set; }  // Navigation to Project
}
}