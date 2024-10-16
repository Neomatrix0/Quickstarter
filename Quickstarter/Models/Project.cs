public class Project
{
    public int ProjectId { get; set; }  // Chiave primaria
    public string Title { get; set; }
    public string Description { get; set; }
    public decimal GoalAmount { get; set; }
    public decimal CurrentAmount { get; set; }
    public DateTime CreatedAt { get; set; }

    // Relazione con ApplicationUser
    public string StartupperId { get; set; }
  //  public ApplicationUser Startupper { get; set; }  // Chi ha creato il progetto
}
