using Quickstarter.Models;
using System.ComponentModel.DataAnnotations;
public class ProjectStartup
{

       // Primary key for the Startup entity
    public int Id { get; set; }  // Primary key recognized by convention


    // project founder used string instead of ApplicationUser only for quick test purpose

    [Required]
    public string Startupper{get;set;}

// will be implemented later 
  //  public ApplicationUser Startupper { get; set; }  

// The name of the company, required field
    [Required]
    public string CompanyName { get; set; }

    // The sector or industry of the startup
     [Required]
    public string Sector { get; set; }

    // A description of the project, required field with a maximum length of 500 characters
    [Required]
    [StringLength(500)]
    public string ProjectDescription { get; set; }

    // The number of employees working in the startup
    public int Employees { get; set; }

    // The startup's future goals or vision
     [Required]
     [StringLength(500)]
    public string FutureGoals { get; set; }

    // The country where the startup is based
     [Required]
    public string Country { get; set; }

    // Optional field for initial capital, can be null
    public decimal? InitialCapital { get; set; }

    // Required field for the funding target that the startup aims to raise
    [Required]
    public decimal TargetFunding { get; set; }

    // Optional link to the startup's website
    public string WebsiteLink { get; set; }

    // creation date
     [Required]
    public DateTime CreatedAt { get; set; }

// will be implement later
  //   public IEnumerable<Contribution> Contributions { get; set; }
}

    /*
    public int ProjectId { get; set; }  // Chiave primaria
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal GoalAmount { get; set; }
    public decimal CurrentAmount { get; set; }
    public DateTime CreatedAt { get; set; }

    

    // Relazione con ApplicationUser
     [Required]
    public ApplicationUser Startupper { get; set; }  // Chi ha creato il progetto
    public IEnumerable<Contribution> Contributions { get; set; }
}*/
