
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Planner2.Data.Models;

[Table("WorkoutPlan")]
public class WorkoutPlan
{
    [Key]
    public int Id { get; set; }
    [Required, MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(500)]
    public string Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public int UserId { get; set; }
    public virtual Users Users {  get; set; }
    
}

